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
        private Client Client = new Client();
        private Reservation Reservation = new Reservation();
        private List<Client> Clients = new List<Client>();
        public HotelWinForm()
        {
            InitializeComponent();
        }
        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            Client.FirstName = txtBoxFirstName.Text;
        }

        private void txtBoxMiddleName_TextChanged(object sender, EventArgs e)
        {
            Client.MiddleName = txtBoxMiddleName.Text;
        }

        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            Client.SurName = txtBoxLastName.Text;
        }

        private void txtBoxEGN_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtBoxEGN.Text, out int egn);
            Client.EGN = egn;
        }

        private void txtBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtBoxEGN.Text, out int phoneNumber);
            Client.PhoneNumber = phoneNumber;
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            Client.Email = txtBoxEmail.Text;
        }

        private void numUpDownAge_ValueChanged(object sender, EventArgs e)
        {
            Client.Age = (int)numUpDownAge.Value;
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

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ResetRegistrationForm();
            radioBtnOneRes.Enabled = false;
            AddNewClient();
        }
        private void AddNewClient()
        {
            Clients.Add(Client);
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