namespace DVLD
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

            bool isLoggedOut = false ;

            do
            {
                frmLoginScreen loginForm = new frmLoginScreen();

                if(loginForm.ShowDialog() != DialogResult.OK)
                {
                    break;
                }

                frmMain mainForm = new frmMain();
                Application.Run(mainForm);

                isLoggedOut = mainForm.IsUserSignedOut;

            } while (isLoggedOut);

        }
    }
}