using KursovaHotel.Data.Models;
using KursovaHotel.Business;
namespace KursovaHotel
{
    public partial class HotelWinForm : Form
    {
        private HotelBusiness HotelBusiness = new HotelBusiness();
        private DateTime BookedOnDate;
        private DateTime ExpiredOnDate;
        private bool IsEnabled = false;
        private int clientCounter = 0;
        private Client client = new Client();
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
            IsEnabled = false;
            monthCalendar.Enabled = true;
            monthCalendar.Visible = true;
        }

        private void btnExpiredOn_Click(object sender, EventArgs e)
        {
            IsEnabled = true;
            monthCalendar.Enabled = true;
            monthCalendar.Visible = true;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!IsEnabled)
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
            }
            int durationInDays = Reservation.ExpiredOn.Day - Reservation.BookedOn.Day;
            if (durationInDays > 0)
            { lblDuration.Text = $"Продължителност на престоя: {durationInDays} дни"; }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (clientCounter > 0)
            {
                clientCounter--;
                SelectPreviousClient();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Clients.Count == clientCounter)
            {
                AddNewClient();
                ResetRegistrationForm();
                clientCounter++;
            }
            else
            {
                clientCounter++;
                txtBoxFirstName.Text = Clients[clientCounter-1].FirstName;
                UpdateCurrentClient();
            }
            radioBtnOneRes.Enabled = false;
        }
        private void UpdateCurrentClient()
        {
            var a = 2;
            int.TryParse(txtBoxEGN.Text, out int egn);
            int.TryParse(txtBoxEGN.Text, out int phoneNumber);
            if (txtBoxFirstName.Text != Clients[clientCounter-1].FirstName
                || txtBoxMiddleName.Text != Clients[clientCounter-1].MiddleName
                || txtBoxLastName.Text != Clients[clientCounter - 1].SurName
                || egn != Clients[clientCounter - 1].EGN
                || phoneNumber != Clients[clientCounter - 1].PhoneNumber
                || txtBoxEmail.Text != Clients[clientCounter - 1].Email)
            {
                Clients[clientCounter - 1].FirstName = txtBoxFirstName.Text;
                Clients[clientCounter - 1].MiddleName = txtBoxMiddleName.Text;
                Clients[clientCounter - 1].SurName = txtBoxLastName.Text;
                Clients[clientCounter - 1].Email = txtBoxEmail.Text;
                Clients[clientCounter - 1].PhoneNumber = egn;
                Clients[clientCounter - 1].PhoneNumber = phoneNumber;
            }
        }
        private void SelectPreviousClient()
        {
            txtBoxFirstName.Text = Clients[clientCounter].FirstName;
        }
        private void AddNewClient()
        {
            client = new Client();
            client.FirstName = txtBoxFirstName.Text;
            client.MiddleName = txtBoxMiddleName.Text;
            client.SurName = txtBoxLastName.Text;
            int.TryParse(txtBoxEGN.Text, out int egn);
            client.EGN = egn;
            int.TryParse(txtBoxEGN.Text, out int phoneNumber);
            client.PhoneNumber = phoneNumber;
            client.Email = txtBoxEmail.Text;
            client.Age = (int)numUpDownAge.Value;
            Clients.Add(client);
            Reservation.IsActive = true;
        }
        private void ResetRegistrationForm()
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
        private void btnSaveRes_Click(object sender, EventArgs e)
        {
            ResetRegistrationForm();
            //HotelBusiness.AddClients(Clients, Reservation);
        }
    }

}