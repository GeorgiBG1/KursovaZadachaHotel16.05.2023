using KursovaHotel.Business;
using KursovaHotel.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaHotel2
{
    public partial class ReservationForm : Form
    {
        private HotelBusiness HotelBusiness = new HotelBusiness();
        private DateTime BookedOnDate;
        private DateTime ExpiredOnDate;
        TimeSpan Duration => Reservation.ExpiredOn.Date - Reservation.BookedOn.Date;
        private bool IsEnabledbtnExpiredOn = false;
        private bool IsAllowedAddClient = true;
        private int clientIndex = 0;
        private Client Client = new Client();
        private List<Room> BookedRooms = new List<Room>();
        private List<Room> ClientRooms = new List<Room>();
        private int roomId;
        private Reservation Reservation = new Reservation();
        private List<Client> Clients = new List<Client>();
        private int menuIndex = 0;
        private bool IsMenuLocked = false;
        private List<Menu> Menus = new List<Menu>();
        private MenuVariety menuVarietyBuffet = new MenuVariety();
        private MenuVariety menuVarietyAllIn = new MenuVariety();
        private MenuVariety menuVarietyVip = new MenuVariety();

        public ReservationForm()
        {
            InitializeComponent();
            ShowAllRooms();
            HotelBusiness.UpdateReservationsStatus();
            HotelBusiness.UpdateRoomsStatus();
        }
        private void radioBtnGroupRes_CheckedChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            btnBack.Visible = true;
            btnNext.Enabled = true;
            btnNext.Visible = true;
        }

        private void radioBtnOneRes_CheckedChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            btnBack.Visible = false;
            btnNext.Enabled = false;
            btnNext.Visible = false;
        }

        private void btnBookedOn_Click(object sender, EventArgs e)
        {
            IsEnabledbtnExpiredOn = false;
            monthCalendar.Enabled = true;
            monthCalendar.Visible = true;
        }

        private void btnExpiredOn_Click(object sender, EventArgs e)
        {
            IsEnabledbtnExpiredOn = true;
            monthCalendar.Enabled = true;
            monthCalendar.Visible = true;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!IsEnabledbtnExpiredOn)
            {
                BookedOnDate = monthCalendar.SelectionRange.Start.Date;
                if (BookedOnDate < ExpiredOnDate)
                {
                    lblDateStart.Text = BookedOnDate.ToShortDateString();
                    lblDateStart.Visible = true;
                    Reservation.BookedOn = BookedOnDate;
                    ResetAllTabPages();
                }
            }
            else
            {
                ExpiredOnDate = monthCalendar.SelectionRange.Start.Date;
                if (ExpiredOnDate.Day > Reservation.BookedOn.Day
                    || ExpiredOnDate.Month > Reservation.BookedOn.Month)
                {
                    lblDateEnd.Text = ExpiredOnDate.ToShortDateString();
                    lblDateEnd.Visible = true;
                    Reservation.ExpiredOn = ExpiredOnDate;
                    ResetAllTabPages();
                }
                btnBookedOn.Enabled = true;
            }
            int durationInDays = Duration.Days;
            if (durationInDays > 0 && Reservation.BookedOn.Year > 1)
            { lblDuration.Text = $"Продължителност на престоя: {durationInDays} нощувки"; }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            RemoveCalendar();
        }
        private void RemoveCalendar()
        {
            monthCalendar.Visible = false;
            monthCalendar.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (clientIndex > 0)
            {
                clientIndex--;
                SelectClient();
                IsAllowedAddClient = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (roomId == 0)
            {
                lblCheckResData.Enabled = true;
                lblCheckResData.Visible = true;
                btnCheckResData.Enabled = true;
                btnCheckResData.Visible = true;
                return;
            }
            clientIndex++;
            var nextClient = Clients.ElementAtOrDefault(clientIndex);
            if (nextClient != null)
            {
                UpdateCurrentClient(clientIndex - 1);
                SelectClient();
            }
            else if (!IsAllowedAddClient)
            {
                UpdateCurrentClient(clientIndex - 1);
                PartialResetRegistrationForm();
                IsAllowedAddClient = true;
            }
            else
            {
                AddNewClient(roomId);
                BookedRooms.Add(HotelBusiness.GetAllRooms().FirstOrDefault(r => r.Id == roomId)!);
                ShowAllRooms();
                PartialResetRegistrationForm();
            }
            radioBtnOneRes.Enabled = false;
        }
        private void UpdateCurrentClient(int index)
        {
            if (Clients.Any())
            {
                if (txtBoxFirstName.Text != Clients[index].FirstName
                    || txtBoxMiddleName.Text != Clients[index].MiddleName
                    || txtBoxLastName.Text != Clients[index].SurName
                    || txtBoxEGN.Text != Clients[index].EGN
                    || txtBoxPhoneNumber.Text != Clients[index].PhoneNumber
                    || txtBoxEmail.Text != Clients[index].Email
                    || numUpDownAge.Value != Clients[index].Age)
                {
                    Clients[index].FirstName = txtBoxFirstName.Text;
                    Clients[index].MiddleName = txtBoxMiddleName.Text;
                    Clients[index].SurName = txtBoxLastName.Text;
                    Clients[index].EGN = txtBoxEGN.Text;
                    Clients[index].PhoneNumber = txtBoxPhoneNumber.Text;
                    Clients[index].Email = txtBoxEmail.Text;
                    Clients[index].Age = (int)numUpDownAge.Value;
                }
            }
        }
        private void SelectClient()
        {
            if (Clients.Any())
            {
                txtBoxFirstName.Text = Clients[clientIndex].FirstName;
                txtBoxMiddleName.Text = Clients[clientIndex].MiddleName;
                txtBoxLastName.Text = Clients[clientIndex].SurName;
                txtBoxEGN.Text = Clients[clientIndex].EGN;
                txtBoxPhoneNumber.Text = Clients[clientIndex].PhoneNumber;
                txtBoxEmail.Text = Clients[clientIndex].Email;
                numUpDownAge.Value = Clients[clientIndex].Age;
            }

        }
        private void AddNewClient(int roomId)
        {
            Client = new Client();
            Client.FirstName = txtBoxFirstName.Text;
            Client.MiddleName = txtBoxMiddleName.Text;
            Client.SurName = txtBoxLastName.Text;
            Client.EGN = txtBoxEGN.Text;
            Client.PhoneNumber = txtBoxPhoneNumber.Text;
            Client.Email = txtBoxEmail.Text;
            Client.Age = (int)numUpDownAge.Value;
            Client.RoomId = roomId;
            Clients.Add(Client);
            Reservation.IsActive = true;
        }
        private void PartialResetRegistrationForm()
        {
            radioBtnOneRes.Enabled = true;
            txtBoxFirstName.Text = "";
            txtBoxMiddleName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxEGN.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxEmail.Text = "";
            numUpDownAge.Value = 0;
        }
        private void ResetRegistrationForm()
        {
            PartialResetRegistrationForm();
            lblDateStart.Text = "";
            lblDateEnd.Text = "";
            lblDuration.Text = "Продължителност на престоя:";
            btnBookedOn.Enabled = false;
            monthCalendar.Enabled = false;
            monthCalendar.Visible = false;
            btnNext.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Visible = false;
            btnBack.Visible = false;
            radioBtnGroupRes.Checked = false;
            radioBtnOneRes.Checked = true;
        }
        private bool CheckResData()
        {
            bool result;
            if (Clients.Any())
            {
                UpdateCurrentClient(clientIndex);
                for (int i = 0; i < Clients.Count; i++)
                {
                    if (Clients[i].FirstName != ""
                        && Clients[i].MiddleName != ""
                        && Clients[i].SurName != ""
                        && Clients[i].EGN!.Length == 10
                        && Clients[i].PhoneNumber!.Length == 10
                        && Clients[i].Email != ""
                        && Clients[i].Age > 0
                        && Clients[i].RoomId != 0)
                    {
                        result = true;
                    }
                    else
                    {
                        if (radioBtnGroupRes.Checked)
                        {
                            clientIndex = i;
                            SelectClient();
                        }
                        else if (radioBtnOneRes.Checked)
                        {
                            Clients = new List<Client>();
                        }
                        lblCheckResData.Enabled = true;
                        lblCheckResData.Visible = true;
                        btnCheckResData.Enabled = true;
                        btnCheckResData.Visible = true;
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            if (Reservation.BookedOn.Year > 1
                && Reservation.ExpiredOn.Year > 1
                && Reservation.Price != 0)
            {
                result = true;
            }
            else
            {
                lblCheckResData.Enabled = true;
                lblCheckResData.Visible = true;
                btnCheckResData.Enabled = true;
                btnCheckResData.Visible = true;
                return false;
            }
            if (Menus.Any())
            {
                result = true;
            }
            else
            {
                lblCheckResData.Enabled = true;
                lblCheckResData.Visible = true;
                btnCheckResData.Enabled = true;
                btnCheckResData.Visible = true;
                return false;
            }
            return result;
        }
        private void btnSaveRes_Click(object sender, EventArgs e)
        {
            AddNewClient(roomId);
            CalculateReservationPrice();
            if (CheckResData())
            {
                Clients = Clients.DistinctBy(c => c.EGN).ToList();
                HotelBusiness.AddClientsWithTheirReservation(Clients, Reservation);
                HotelBusiness.UpdateReservationsStatus();
                HotelBusiness.UpdateRoomsStatus();
                HotelBusiness.AddClientMenus(Menus);
                lblCheckResData.Enabled = false;
                lblCheckResData.Visible = false;
                btnCheckResData.Enabled = false;
                btnCheckResData.Visible = false;
                ResetRegistrationForm();
                ResetAllTabPages();
                BookedOnDate = new DateTime();
                ExpiredOnDate = new DateTime();
                Reservation = new Reservation();
                Clients = new List<Client>();
                BookedRooms = new List<Room>();
                roomId = 0;
                clientIndex = 0;
                ShowAllRooms();
            }
        }
        private void btnDelAll_Click(object sender, EventArgs e)
        {
            HotelBusiness.DeleteAll();
            HotelBusiness = new HotelBusiness();
            ShowAllRooms();
        }
        private void ShowAllRooms(int roomNumber = 0)
        {
            var allRooms = HotelBusiness.GetAllRooms();
            Dictionary<int, Button> rooms = new Dictionary<int, Button>();
            rooms.Add(10, btnRoom10);
            rooms.Add(11, btnRoom11);
            rooms.Add(12, btnRoom12);
            rooms.Add(13, btnRoom13);
            rooms.Add(14, btnRoom14);
            rooms.Add(15, btnRoom15);
            rooms.Add(20, btnRoom20);
            rooms.Add(21, btnRoom21);
            rooms.Add(22, btnRoom22);
            rooms.Add(23, btnRoom23);
            rooms.Add(24, btnRoom24);
            rooms.Add(25, btnRoom25);
            rooms.Add(30, btnRoom30);
            rooms.Add(31, btnRoom31);
            rooms.Add(32, btnRoom32);
            rooms.Add(33, btnRoom33);
            rooms.Add(34, btnRoom34);
            rooms.Add(35, btnRoom35);

            foreach (var room in allRooms)
            {
                if (!room.IsBooked)
                {
                    rooms[room.RoomNumber].BackColor = Color.DarkGreen;
                }
                else
                {
                    rooms[room.RoomNumber].BackColor = Color.DarkRed;
                }
            }
            if (roomNumber != 0)
            {
                var selectedRoom = rooms.FirstOrDefault(r => r.Key == roomNumber);
                selectedRoom.Value.BackColor = Color.CadetBlue;
            }
            for (int i = 0; i < rooms.Count; i++)
            {
                for (int j = 0; j < BookedRooms.Count; j++)
                {
                    if (i == BookedRooms[j].Id - 1)
                    {
                        var room = rooms.ElementAt(i).Value;
                        room.BackColor = Color.DarkRed;
                    }
                }
            }
        }
        private void btnRoom10_Click(object sender, EventArgs e)
        {
            roomId = 1;
            ShowAllRooms(10);
        }
        private void btnRoom11_Click(object sender, EventArgs e)
        {
            roomId = 2;
            ShowAllRooms(11);
        }
        private void btnRoom12_Click(object sender, EventArgs e)
        {
            roomId = 3;
            ShowAllRooms(12);
        }
        private void btnRoom13_Click(object sender, EventArgs e)
        {
            roomId = 4;
            ShowAllRooms(13);
        }
        private void btnRoom14_Click(object sender, EventArgs e)
        {
            roomId = 5;
            ShowAllRooms(14);
        }
        private void btnRoom15_Click(object sender, EventArgs e)
        {
            roomId = 6;
            ShowAllRooms(15);
        }
        private void btnRoom20_Click(object sender, EventArgs e)
        {
            roomId = 7;
            ShowAllRooms(20);
        }
        private void btnRoom21_Click(object sender, EventArgs e)
        {
            roomId = 8;
            ShowAllRooms(21);
        }
        private void btnRoom22_Click(object sender, EventArgs e)
        {
            roomId = 9;
            ShowAllRooms(22);
        }
        private void btnRoom23_Click(object sender, EventArgs e)
        {
            roomId = 10;
            ShowAllRooms(23);
        }
        private void btnRoom24_Click(object sender, EventArgs e)
        {
            roomId = 11;
            ShowAllRooms(24);
        }
        private void btnRoom25_Click(object sender, EventArgs e)
        {
            roomId = 12;
            ShowAllRooms(25);
        }
        private void btnRoom30_Click(object sender, EventArgs e)
        {
            roomId = 13;
            ShowAllRooms(30);
        }
        private void btnRoom31_Click(object sender, EventArgs e)
        {
            roomId = 14;
            ShowAllRooms(31);
        }
        private void btnRoom32_Click(object sender, EventArgs e)
        {
            roomId = 15;
            ShowAllRooms(32);
        }
        private void btnRoom33_Click(object sender, EventArgs e)
        {
            roomId = 16;
            ShowAllRooms(33);
        }
        private void btnRoom34_Click(object sender, EventArgs e)
        {
            roomId = 17;
            ShowAllRooms(34);
        }
        private void btnRoom35_Click(object sender, EventArgs e)
        {
            roomId = 18;
            ShowAllRooms(35);
        }
        private void ResetAllTabPages()
        {
            IsMenuLocked = false;
            lblMenuOnOffPage1.Enabled = true;
            lblMenuOnOffPage1.Visible = true;
            lblMenuOnOffPage2.Enabled = true;
            lblMenuOnOffPage2.Visible = true;
            lblMenuOnOffPage3.Enabled = true;
            lblMenuOnOffPage3.Visible = true;
            lblMenuOnOffPage4.Enabled = true;
            lblMenuOnOffPage4.Visible = true;
            lblCompletedMenu1.Enabled = false;
            lblCompletedMenu1.Visible = false;
            lblCompletedMenu2.Enabled = false;
            lblCompletedMenu2.Visible = false;
            lblCompletedMenu3.Enabled = false;
            lblCompletedMenu3.Visible = false;
            lblCompletedMenu4.Enabled = false;
            lblCompletedMenu4.Visible = false;
            lblMenuDate.Enabled = false;
            lblMenuDate.Visible = false;
            lblSelectedMenu.Enabled = false;
            lblSelectedMenu.Visible = false;
            lblBuffetInfo.Enabled = false;
            lblBuffetInfo.Visible = false;
            lblAllInclusiveInfo.Enabled = false;
            lblAllInclusiveInfo.Visible = false;
            lblVipMenuInfo.Enabled = false;
            lblVipMenuInfo.Visible = false;
            checkedListBoxMenu.Enabled = false;
            checkedListBoxMenu.Visible = false;
            checkedListBoxMenu.Items.Clear();
            checkedListBoxMenu.Items.Add("Закуска");
            checkedListBoxMenu.Items.Add("Обяд");
            checkedListBoxMenu.Items.Add("Вечеря");
            Menus = new List<Menu>();
            menuVarietyBuffet = new MenuVariety();
            menuVarietyAllIn = new MenuVariety();
            menuVarietyVip = new MenuVariety();
            menuIndex = 0;
            lblBreakfast.Enabled = false;
            lblBreakfast.Visible = false;
            lblLunch.Enabled = false;
            lblLunch.Visible = false;
            lblDinner.Enabled = false;
            lblDinner.Visible = false;
            btnPreviousDay.Enabled = false;
            btnPreviousDay.Visible = false;
            btnNextDay.Enabled = false;
            btnNextDay.Visible = false;
            btnNextDay.Text = "Следващ ден";
        }
        private void LockAllTapPages()
        {
            IsMenuLocked = true;
            lblCompletedMenu1.Enabled = true;
            lblCompletedMenu1.Visible = true;
            lblCompletedMenu2.Enabled = true;
            lblCompletedMenu2.Visible = true;
            lblCompletedMenu3.Enabled = true;
            lblCompletedMenu3.Visible = true;
            lblCompletedMenu4.Enabled = true;
            lblCompletedMenu4.Visible = true;
            lblMenuDate.Enabled = false;
            lblMenuDate.Visible = false;
            lblSelectedMenu.Enabled = false;
            lblSelectedMenu.Visible = false;
            lblBuffetInfo.Enabled = false;
            lblBuffetInfo.Visible = false;
            lblAllInclusiveInfo.Enabled = false;
            lblAllInclusiveInfo.Visible = false;
            lblVipMenuInfo.Enabled = false;
            lblVipMenuInfo.Visible = false;
            checkedListBoxMenu.Enabled = false;
            checkedListBoxMenu.Visible = false;
            lblBreakfast.Enabled = false;
            lblBreakfast.Visible = false;
            lblLunch.Enabled = false;
            lblLunch.Visible = false;
            lblDinner.Enabled = false;
            lblDinner.Visible = false;
            btnPreviousDay.Enabled = false;
            btnPreviousDay.Visible = false;
            btnNextDay.Enabled = false;
            btnNextDay.Visible = false;
        }
        private bool AddMenu()
        {
            Menus = new List<Menu>();
            if (Duration.Days >= 1 && Reservation.BookedOn.Year != 1)
            {
                lblMenuOnOffPage1.Enabled = false;
                lblMenuOnOffPage1.Visible = false;
                lblMenuOnOffPage2.Enabled = false;
                lblMenuOnOffPage2.Visible = false;
                lblMenuOnOffPage3.Enabled = false;
                lblMenuOnOffPage3.Visible = false;
                lblMenuOnOffPage4.Enabled = false;
                lblMenuOnOffPage4.Visible = false;

                DateTime menuDate = Reservation.BookedOn.Date;
                int counter = Duration.Days;
                while (counter >= 1)
                {
                    if (!Menus.Any())
                    {
                        Menus.Add(new Menu()
                        { Date = menuDate });
                    }
                    Menus.Add(new Menu()
                    {
                        Date = menuDate.AddDays(counter)
                    });
                    counter--;
                }
                Menus = Menus.OrderBy(m => m.Date).ToList();
                return true;
            }
            return false;
        }
        private void tabPageWithMenus_Click(object sender, EventArgs e)
        {
            if (!IsMenuLocked)
            {
                if (AddMenu())
                {
                    lblCompletedMenu1.Enabled = false;
                    lblCompletedMenu1.Visible = false;
                    lblMenuDate.Enabled = true;
                    lblMenuDate.Visible = true;
                    lblMenuDate.Text = $"{Reservation.BookedOn.ToShortDateString()}";
                    lblSelectedMenu.Enabled = true;
                    lblSelectedMenu.Visible = true;
                    checkedListBoxMenu.Enabled = true;
                    checkedListBoxMenu.Visible = true;
                    checkedListBoxMenu.CheckOnClick = true;
                    btnNextDay.Enabled = true;
                    btnNextDay.Visible = true;
                    btnPreviousDay.Enabled = true;
                    btnPreviousDay.Visible = true;
                }
            }
        }
        private void tabPageBuffet_Click(object sender, EventArgs e)
        {
            if (!IsMenuLocked)
            {
                if (AddMenu() && menuVarietyBuffet.Name == null)
                {
                    lblCompletedMenu2.Enabled = false;
                    lblCompletedMenu2.Visible = false;
                    menuVarietyBuffet = HotelBusiness
                        .GetMenuVarietyByName("Buffet");
                    lblBuffetInfo.Enabled = true;
                    lblBuffetInfo.Visible = true;
                    lblBuffetInfo.Text = $"Описание на блок масата:\r\n{menuVarietyBuffet.Description}\n" +
                        $"Закуска: ✓\n" +
                        $"Обяд: ✓\n" +
                        $"Вечеря: ✓\n\n\n\nЦена: {menuVarietyBuffet.Price}лв";
                }
            }
        }
        private void tabPageALLIn_Click(object sender, EventArgs e)
        {
            if (!IsMenuLocked)
            {
                if (AddMenu() && menuVarietyAllIn.Name == null)
                {
                    lblCompletedMenu3.Enabled = false;
                    lblCompletedMenu3.Visible = false;
                    menuVarietyAllIn = HotelBusiness
                        .GetMenuVarietyByName("All Inclusive");
                    lblAllInclusiveInfo.Enabled = true;
                    lblAllInclusiveInfo.Visible = true;
                    lblAllInclusiveInfo.Text = $"Описание на All Inclusive пакет:\r\n{menuVarietyAllIn.Description}\n" +
                        $"Закуска: ✓\n" +
                        $"Обяд: ✓\n" +
                        $"Вечеря: ✓\n\n\n\nЦена: {menuVarietyAllIn.Price}лв";
                }
            }
        }
        private void tabPageVipMenu_Click(object sender, EventArgs e)
        {
            if (!IsMenuLocked)
            {
                if (AddMenu() && menuVarietyVip.Name == null)
                {
                    lblCompletedMenu4.Enabled = false;
                    lblCompletedMenu4.Visible = false;
                    menuVarietyVip = HotelBusiness
                        .GetMenuVarietyByName("VIP");
                    lblVipMenuInfo.Enabled = true;
                    lblVipMenuInfo.Visible = true;
                    lblVipMenuInfo.Text = $"Описание на VIP менюто:\r\n{menuVarietyVip.Description}\n" +
                        $"Закуска: ✓\n" +
                        $"Обяд: ✓\n" +
                        $"Вечеря: ✓\n\n\n\nЦена: {menuVarietyVip.Price}лв";
                }
            }
        }
        private bool AddMenuOption()
        {
            var checkedItems = checkedListBoxMenu.CheckedItems;
            if (checkedItems.Count != 0)
            {
                if (checkedItems.Count < 2)
                {
                    if (checkedItems[0] == "Закуска")
                    {
                        Menus[menuIndex].MenuOptionId = 2;
                        lblBreakfast.Enabled = true;
                        lblBreakfast.Visible = true;
                        lblBreakfast.Text = "Закуска от 7:00ч до 9:00ч";
                    }
                    else if (checkedItems[0] == "Обяд")
                    {
                        Menus[menuIndex].MenuOptionId = 4;
                        lblLunch.Enabled = true;
                        lblLunch.Visible = true;
                        lblLunch.Text = "Обяд от 11:30ч до 12:30ч";
                    }
                    else
                    {
                        Menus[menuIndex].MenuOptionId = 6;
                        lblDinner.Enabled = true;
                        lblDinner.Visible = true;
                        lblDinner.Text = "Вечеря от 19:00ч до 20:30ч";
                    }
                }
                else if (checkedItems.Count == 2)
                {
                    if (checkedItems[0] == "Закуска" && checkedItems[1] == "Обяд")
                    {
                        Menus[menuIndex].MenuOptionId = 3;
                        lblBreakfast.Enabled = true;
                        lblBreakfast.Visible = true;
                        lblBreakfast.Text = "Закуска от 7:00ч до 9:00ч";
                        lblLunch.Enabled = true;
                        lblLunch.Visible = true;
                        lblLunch.Text = "Обяд от 11:30ч до 12:30ч";
                    }
                    else if (checkedItems[0] == "Обяд" && checkedItems[1] == "Вечеря")
                    {
                        Menus[menuIndex].MenuOptionId = 5;
                        lblBreakfast.Enabled = true;
                        lblBreakfast.Visible = true;
                        lblBreakfast.Text = "Закуска от 7:00ч до 9:00ч";
                        lblDinner.Enabled = true;
                        lblDinner.Visible = true;
                        lblDinner.Text = "Вечеря от 19:00ч до 20:30ч";
                    }
                    else if (checkedItems[0] == "Закуска" && checkedItems[1] == "Вечеря")
                    {
                        Menus[menuIndex].MenuOptionId = 7;
                        lblBreakfast.Enabled = true;
                        lblBreakfast.Visible = true;
                        lblBreakfast.Text = "Закуска от 7:00ч до 9:00ч";
                        lblDinner.Enabled = true;
                        lblDinner.Visible = true;
                        lblDinner.Text = "Вечеря от 19:00ч до 20:30ч";
                    }
                }
                else
                {
                    Menus[menuIndex].MenuOptionId = 8;
                    lblBreakfast.Enabled = true;
                    lblBreakfast.Visible = true;
                    lblBreakfast.Text = "Закуска от 7:00ч до 9:00ч";
                    lblLunch.Enabled = true;
                    lblLunch.Visible = true;
                    lblLunch.Text = "Обяд от 11:30ч до 12:30ч";
                    lblDinner.Enabled = true;
                    lblDinner.Visible = true;
                    lblDinner.Text = "Вечеря от 19:00ч до 20:30ч";
                }
                return true;
            }
            else
            {
                lblCheckResData.Enabled = true;
                lblCheckResData.Visible = true;
                btnCheckResData.Enabled = true;
                btnCheckResData.Visible = true;
                return false;
            }
        }
        private void btnNextDay_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMenu.CheckedItems.Count > 0 && menuIndex < Menus.Count - 1)
            {
                if (AddMenuOption())
                {
                    menuIndex++;
                    lblMenuDate.Text = Menus[menuIndex].Date.ToShortDateString();
                    if (Menus[menuIndex].Date == Reservation.ExpiredOn)
                    {
                        btnNextDay.Text = "Завършек";
                    }
                }
            }
            else
            {
                if (AddMenuOption())
                {
                    if (btnNextDay.Text == "Завършек")
                    {
                        LockAllTapPages();
                    }
                }
            }
        }
        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMenu.CheckedItems.Count > 0 && menuIndex >= 1)
            {
                if (AddMenuOption())
                {
                    menuIndex--;
                    lblMenuDate.Text = Menus[menuIndex].Date.ToShortDateString();
                }
            }
            if (btnNextDay.Text == "Завършек")
            {
                btnNextDay.Text = "Следващ ден";
            }
        }
        private void SelectMenuVariety()
        {
            if (tabControlMenu.SelectedIndex == 0)
            {
                foreach (var menu in Menus)
                {
                    menu.MenuVarietyId = 4;
                }
            }
            else if (tabControlMenu.SelectedIndex == 1)
            {
                foreach (var menu in Menus)
                {
                    menu.MenuOptionId = 1;
                    menu.MenuVarietyId = 3;
                }
            }
            else if (tabControlMenu.SelectedIndex == 2)
            {
                foreach (var menu in Menus)
                {
                    menu.MenuOptionId = 1;
                    menu.MenuVarietyId = 2;
                }
            }
            else if (tabControlMenu.SelectedIndex == 3)
            {
                foreach (var menu in Menus)
                {
                    menu.MenuOptionId = 1;
                    menu.MenuVarietyId = 1;
                }
            }
        }
        private void CalculatePriceForEveryMenu()
        {
            foreach (var menu in Menus)
            {
                var menuVariety = HotelBusiness.GetMenuVarietyById(menu.MenuVarietyId);
                var menuOption = HotelBusiness.GetMenuOptionById(menu.MenuOptionId);
                menu.Price = menuVariety.Price + menuOption.Price;
            }
        }
        private void CalculateReservationPrice()
        {
            SelectMenuVariety();
            CalculatePriceForEveryMenu();
            foreach (var menu in Menus)
            {
                Reservation.Price += menu.Price;
            }
            foreach (var client in Clients)
            {
                var clientRoom = HotelBusiness.GetRoomById(client!.RoomId);
                ClientRooms.Add(clientRoom);
            }
            ClientRooms = ClientRooms.Distinct().ToList();
            foreach (var clientRoom in ClientRooms)
            {
                if (clientRoom != null)
                {
                    Reservation.Price += clientRoom.Price * Reservation.Duration;
                }
            }
        }

        private void lblFloor1_DoubleClick(object sender, EventArgs e)
        {
            btnDelAll.Enabled = true;
            btnDelAll.Visible = true;
        }

        private void lblFloor2_DoubleClick(object sender, EventArgs e)
        {
            btnDelAll.Enabled = false;
            btnDelAll.Visible = false;
        }

        private void btnCheckResData_Click(object sender, EventArgs e)
        {
            lblCheckResData.Enabled = false;
            lblCheckResData.Visible = false;
            btnCheckResData.Enabled = false;
            btnCheckResData.Visible = false;
        }
    }
}