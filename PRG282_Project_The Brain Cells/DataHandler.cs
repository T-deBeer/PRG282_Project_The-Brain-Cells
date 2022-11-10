using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project_The_Brain_Cells
{
    internal class DataHandler
    {
        string TextPath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\TestText.txt";
        public void WriteLogin()
        {
            if (File.Exists(TextPath))
            {
                File.Delete(TextPath);
                //FileHandler createText = new FileHandler();
                //createText.CreateTextFile(TextPath);
            }

           

            List<Credential> lines = new List<Credential>();
            DataBaseHandler data = new DataBaseHandler();
            lines = data.GetCreds();
            using (TextWriter writer = new StreamWriter(TextPath))
            {
                foreach (var cred in lines)
                {
                    writer.WriteLine(cred.Username +","+cred.Password);
                }
            }
        }
        public string[] ReadTextFile()
        {
            string[] fileContent = { null };
            try
            {
                fileContent = File.ReadAllLines(TextPath);
            }
            catch
            {
                
            }

            if (!(fileContent.Length == 0))
            {
                return fileContent;
            }
            return fileContent;
        }
        public bool WriteTextFile(string userPasswordString)
        {
            bool success = false;
            try
            {
                File.AppendAllText(TextPath, userPasswordString);
                success = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return success;


        }
    }
}
