using System;
using System.Collections.Generic;
using System.Data;
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


        public List<Credential> CredentialsToList(DataTable data)
        {
            List<Credential> list = new List<Credential>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                list.Add(new Credential(data.Rows[i]["Username"].ToString(), data.Rows[i]["Password"].ToString()));
            }
            return list;
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
                FileHandler createText = new FileHandler();
                createText.CreateTextFile(TextPath);
                fileContent = File.ReadAllLines(TextPath);
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
