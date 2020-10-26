using System;
using System.IO;
using System.Windows.Forms;

namespace InfinityLibrary.Helpers
{
    /// <summary>
    /// Handles exceptions with logging and displaying functions
    /// </summary>
    static class ExceptionHandler
    {
        /// <summary>
        /// Common SQLException
        /// </summary>
        internal static Exception dbCorruptedEx = new Exception("The database is corrupted"); 

        /// <summary>
        /// Log exception details in a text file
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        internal static Exception Log(this Exception ex)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) // C:\Users\[USERNAME]\AppData\Roaming
                + @"\Infinity Defect Management System\Logs"; 
            DirectoryInfo di = Directory.CreateDirectory(path); // Create the directory if it does not exists
            File.AppendAllText(path + @"\Exception Log " + DateTime.Now.ToString("yyyy-MM-dd") + ".log", 
                DateTime.Now.ToString("HH:mm:ss") + ": " + "\n" + ex.ToString() + "\n\n"); // Write the log file
            return ex;
        }

        /// <summary>
        /// Display exception details through a MessageBox
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="msg"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        internal static Exception Display(this Exception ex, string msg = null, MessageBoxIcon img = MessageBoxIcon.Warning)
        {
            MessageBox.Show(msg ?? ex.Message, "Error", MessageBoxButtons.OK, img);
            return ex;
        }
    }
}
