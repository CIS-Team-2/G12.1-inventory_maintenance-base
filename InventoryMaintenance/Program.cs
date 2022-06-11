using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************************************************
* CIS 123: Introduction to OOP     |    Exercise 14-1 Use inheritance                              *
* Murach's C#, 7th Edition         |    Add 2 classes to the Inventory Maintenance application     *
* Chapter 14 Extra Exercises       |    that inherit the InvItem class. Add code to the forms to   *
* Team 2 Assignment, 11JUN2022     |    provide for these new classes:                             *
* Patrick McKee & Dominique Tepper |           (1) Plant, (2) Supply                               *
***************************************************************************************************/

namespace InventoryMaintenance
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInvMaint());
        }
    }
}
