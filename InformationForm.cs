using KursovaHotel.Business;
using KursovaHotel.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaHotel2
{
    public partial class InformationForm : Form
    {
        private HotelBusiness HotelBusiness = new HotelBusiness();
        private bool btnOrderClientsUpDown = false;
        private List<Client> AllClients = new List<Client>();
        public InformationForm()
        {
            InitializeComponent();
            btnOrderClients.Text = char.ConvertFromUtf32(0x2191);
            AllClients = HotelBusiness.GetAllClientsOrderedByReservations();
            ShowAllClients();
        }
        public void ShowAllClients()
        {

            foreach (var client in AllClients)
            {
                listBoxClients.Items.Add($"{client.FirstName} " +
                    $"{client.MiddleName} {client.SurName} " +
                    $"ЕГН: {client.EGN} Email: {client.Email} " +
                    $"Телефон: {client.PhoneNumber} Стая: {client.Room?.RoomNumber} " +
                    $"Резервация №{client.ReservationId}");
                listBoxClients.SelectedIndex = 0;
            }
        }
        public void ShowClientReservation(int index)
        {
            if (!btnOrderClientsUpDown)
            {
                var client = HotelBusiness.GetClientById(index);
                if (client != null)
                {
                    var menu = client.Reservation!.Menus!.FirstOrDefault();
                    var menuVariety = new MenuVariety();
                    Label reservationStatus = new Label();
                    if (menu != null)
                    {
                        menuVariety = HotelBusiness
                           .GetMenuVarietyById(menu!.MenuVarietyId);
                    }
                    if (client.Reservation.IsActive)
                    {
                        reservationStatus.Text = "Статус: \u2713";
                    }
                    else
                    {
                        reservationStatus.Text = "Статус: X";
                    }
                    listBoxReservations.Items.Add(
                        $"Резервация №{client.Reservation.Id}. " +
                        $"Меню: {menuVariety!.Name}. " +
                        $"Oт: {client.Reservation.BookedOn.ToShortDateString()} " +
                        $"До: {client.Reservation.ExpiredOn.ToShortDateString()} " +
                        $"- {client.Reservation.Duration} нощувки. Цена: {client.Reservation.Price}лв " +
                        $"{reservationStatus.Text}");
                }
            }
        }

        private void btnDisableRes_Click(object sender, EventArgs e)
        {
            int index = listBoxClients.SelectedIndex;
            var client = HotelBusiness.GetClientById(index + 1);
            HotelBusiness.UpdateReservationsStatus(client.Reservation!);
            HotelBusiness.UpdateRoomsStatus();
            listBoxClients.Items.Clear();
            listBoxReservations.Items.Clear();
            AllClients = HotelBusiness.GetAllClientsOrderedByReservations();
            ShowAllClients();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HotelBusiness.UpdateReservationsStatus();
            HotelBusiness.UpdateRoomsStatus();
            listBoxClients.Items.Clear();
            listBoxReservations.Items.Clear();
            AllClients = HotelBusiness.GetAllClientsOrderedByReservations();
            ShowAllClients();
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxReservations.Items.Clear();
            int index = listBoxClients.SelectedIndex;
            ShowClientReservation(index + 1);
        }

        private void btnOrderClients_Click(object sender, EventArgs e)
        {
            if (AllClients.Count != 0)
            {
                if (btnOrderClientsUpDown)
                {
                    btnOrderClients.Text = char.ConvertFromUtf32(0x2191);
                    btnOrderClientsUpDown = false;
                    btnDisableRes.Enabled = true;
                    btnRefresh.Enabled = true;
                    AllClients = AllClients.OrderBy(c => c.Id).ToList();
                    listBoxClients.Items.Clear();
                    listBoxReservations.Items.Clear();
                    ShowAllClients();
                }
                else
                {
                    btnOrderClients.Text = char.ConvertFromUtf32(0x2193);
                    btnOrderClientsUpDown = true;
                    btnDisableRes.Enabled = false;
                    btnRefresh.Enabled = false;
                    AllClients = AllClients.OrderByDescending(c => c.Id).ToList();
                    listBoxClients.Items.Clear();
                    listBoxReservations.Items.Clear();
                    ShowAllClients();
                }
            }
        }
    }
}
