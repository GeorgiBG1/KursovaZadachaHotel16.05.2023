using KursovaHotel.Data.Models;
using KursovaHotel.Business;
namespace KursovaHotel
{
    public partial class HotelWinForm : Form
    {
        private HotelBusiness HotelBusiness = new HotelBusiness();
        private DateTime BookedOnDate;
        private DateTime ExpiredOnDate;
        private bool IsEnabledbtnExpiredOn = false;
        private bool IsAllowedAddClient = true;
        private int clientIndex = 0;
        private Client Client = new Client();
        private Reservation Reservation = new Reservation();
        public List<Client> Clients = new List<Client>();
        public HotelWinForm()
        {
            InitializeComponent();
        }
        private void radioBtnGroupRes_CheckedChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            btnBack.Visible = true;
            btnNext.Enabled = true;
            btnNext.Visible = true;
        }

        private void radioBtnOneRes_CheckedChanged_1(object sender, EventArgs e)
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
                }
            }
            else
            {
                ExpiredOnDate = monthCalendar.SelectionRange.Start.Date;
                if (ExpiredOnDate.Day > Reservation.BookedOn.Day)
                {
                    lblDateEnd.Text = ExpiredOnDate.ToShortDateString();
                    lblDateEnd.Visible = true;
                    Reservation.ExpiredOn = ExpiredOnDate;
                }
                btnBookedOn.Enabled = true;
            }
            int durationInDays = Reservation.ExpiredOn.Day - Reservation.BookedOn.Day;
            if (durationInDays > 0 && Reservation.BookedOn.Year > 1)
            { lblDuration.Text = $"Продължителност на престоя: {durationInDays} нощувки"; }
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
                AddNewClient();
                PartialResetRegistrationForm();
            }
            radioBtnOneRes.Enabled = false;
        }
        private void UpdateCurrentClient(int index)
        {
            if (Clients.Any())
            {
                int.TryParse(txtBoxEGN.Text, out int egn);
                int.TryParse(txtBoxPhoneNumber.Text, out int phoneNumber);
                if (txtBoxFirstName.Text != Clients[index].FirstName
                    || txtBoxMiddleName.Text != Clients[index].MiddleName
                    || txtBoxLastName.Text != Clients[index].SurName
                    || egn != Clients[index].EGN
                    || phoneNumber != Clients[index].PhoneNumber
                    || txtBoxEmail.Text != Clients[index].Email
                    || numUpDownAge.Value != Clients[index].Age)
                {
                    Clients[index].FirstName = txtBoxFirstName.Text;
                    Clients[index].MiddleName = txtBoxMiddleName.Text;
                    Clients[index].SurName = txtBoxLastName.Text;
                    Clients[index].EGN = egn;
                    Clients[index].PhoneNumber = phoneNumber;
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
                txtBoxEGN.Text = Clients[clientIndex].EGN.ToString();
                txtBoxPhoneNumber.Text = Clients[clientIndex].PhoneNumber.ToString();
                txtBoxEmail.Text = Clients[clientIndex].Email;
                numUpDownAge.Value = Clients[clientIndex].Age;
            }

        }
        private void AddNewClient()
        {
            Client = new Client();
            Client.FirstName = txtBoxFirstName.Text;
            Client.MiddleName = txtBoxMiddleName.Text;
            Client.SurName = txtBoxLastName.Text;
            int.TryParse(txtBoxEGN.Text, out int egn);
            Client.EGN = egn;
            int.TryParse(txtBoxPhoneNumber.Text, out int phoneNumber);
            Client.PhoneNumber = phoneNumber;
            Client.Email = txtBoxEmail.Text;
            Client.Age = (int)numUpDownAge.Value;
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
        private void btnSaveRes_Click(object sender, EventArgs e)
        {
            if (radioBtnOneRes.Checked)
            {
                AddNewClient();
                ResetRegistrationForm();
                HotelBusiness.AddClientsWithTheirReservation(Clients, Reservation);
                BookedOnDate = new DateTime();
                ExpiredOnDate = new DateTime();
                Reservation = new Reservation();
                Clients = new List<Client>();
            }
            else if (radioBtnGroupRes.Checked)
            {
                AddNewClient();
                ResetRegistrationForm();
                HotelBusiness.AddClientsWithTheirReservation(Clients, Reservation);
                BookedOnDate = new DateTime();
                ExpiredOnDate = new DateTime();
                Reservation = new Reservation();
                Clients = new List<Client>();
                clientIndex = 0;
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            HotelBusiness.DeleteAll();
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel1.Visible = true;
        }
    }

}