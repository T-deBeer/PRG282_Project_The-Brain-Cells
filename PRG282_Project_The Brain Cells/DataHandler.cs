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
        string LogFilePath = Convert.ToString(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location))
                 + "\\LogFile.txt";
        public List<string> LogData = new List<string>();
        public void WriteLogin()
        {
            if (File.Exists(TextPath))
            {
                File.Delete(TextPath);
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
        public void WriteLogFile()
        {
            if (File.Exists(LogFilePath))
            {
                File.Delete(LogFilePath);
            }

            using (TextWriter writer = new StreamWriter(LogFilePath))
            {
                for (int i = 0; i < LogData.Count; i++)
                {
                    writer.WriteLine(LogData[i]);
                }
            }
        }
        public void AddToLog(string String)
        {
            LogData.Add(String);
        }
        public List<string> GetLog()
        {
            
            try
            {
                LogData = File.ReadAllLines(LogFilePath).ToList();
            }
            catch
            {
                MessageBox.Show("There was an error retrieving the log file");
            }

            if (!(LogData.Count == 0))
            {
                return LogData;
            }
            return LogData;
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
