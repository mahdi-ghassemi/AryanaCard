using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace AryanaCard
{
    static class Program
    {
        public static string studentID = "";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
            //Application.Run(new MainFrm());
        }
    }
}
