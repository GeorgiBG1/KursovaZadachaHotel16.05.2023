using KursovaHotel.Business;
using KursovaHotel.Data;

namespace KursovaHotel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HotelDbContext dbContext = new HotelDbContext();
            HotelBusiness hotelBusiness = new HotelBusiness();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HotelWinForm());
        }
    }
}