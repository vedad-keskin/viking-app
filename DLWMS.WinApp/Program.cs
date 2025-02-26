using DLWMS.WinApp.Forms;

namespace DLWMS.WinApp
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

            // Brzo testiranje
            //var startnaForma = new frmNalozi(1);

            // Produkcijski
            var startnaForma = new frmLogin();

            Application.Run(startnaForma);
        }
    }
}