using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread t = new Thread(StartSplash);
            t.Start();
            Thread.Sleep(8000);
            t.Abort();
            Application.Run(new LoginForm());

        }

       public static void  StartSplash()
        {
            Application.Run(new SplashScreen());
        }
    }
}
