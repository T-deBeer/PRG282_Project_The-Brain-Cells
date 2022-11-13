using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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
            string soundLocation =Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\SplashSound.wav";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread t = new Thread(StartSplash);
            t.Start();
            using (var soundPlayer = new SoundPlayer(@""+soundLocation))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            Thread.Sleep(5000);
            t.Abort();
            Application.Run(new LoginForm());
           

        }

       public static void  StartSplash()
        {
            Application.Run(new SplashScreen());
        }
    }
}
