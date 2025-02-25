using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Waste_Management;

namespace Student
{
    internal class Program //Added the program.cs file because the app wasn't loading
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CfrmMain()); // Ensure CfrmMain is correctly spelled
        }
    }
}
