using TravelEase.Moduler_Admin;
using TravelEase.PassengerDashboards;
using TravelEase.WelcomeModel;

namespace TravelEase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormLogIn());
            //Application.Run(new PassengerDashboard());
            //Application.Run(new ModulerAdminDashboard());
            Application.Run(new NewModuler());
        }
    }
}