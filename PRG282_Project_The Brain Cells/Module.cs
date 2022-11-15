using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_The_Brain_Cells
{
    public class Module
    {
        public Module()
        {
        }

        public Module(string moduleCode, string moduleName, string moduleDescription, string moduleResource)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleDescription = moduleDescription;
            ModuleResource = moduleResource;
        }

        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleResource { get; set; }

        public string Display()
        {
            return $"Code: {this.ModuleCode} | Name: {this.ModuleName}";
        }
    }
}
