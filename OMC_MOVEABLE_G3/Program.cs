using System;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// The application starts at the login form. When the login form
        /// closes, the whole application closes.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splashhh());
        }
    }
}
