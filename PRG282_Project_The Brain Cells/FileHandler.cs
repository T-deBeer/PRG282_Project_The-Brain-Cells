using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project_The_Brain_Cells
{
    internal class FileHandler
    {
        public void CreateTextFile(string filePath)
        {
            //creates a text file
            File.Create(filePath);
        }
    }
}
