using ConcertTicketingSystem;

namespace Ticket_Ease
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
            //Application.Run(new DashboardForm("KDads123", false));
            //Application.Run(new RegisterForm());
            Application.Run(new GetStartedForm());
        }
    }
}