using System;
using System.Windows.Forms;

namespace Infinity
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "{0a512a62-3578-4508-af55-3ee0d4f22ee2}", out result); // Check if the app is already running

            if (!result)
            {
                // An instance is already running
                MessageBox.Show("Another instance of the application is already running.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.Login);

            GC.KeepAlive(mutex); // Keep the mutex without releasing
        }
    }
}
