using System;
using System.Collections.Generic;
using System.Text;

/***************************************************************************************************
* CIS 123: Introduction to OOP     |    Exercise 14-1 Use inheritance                              *
* Murach's C#, 7th Edition         |    Add 2 classes to the Inventory Maintenance application     *
* Chapter 14 Extra Exercises       |    that inherit the InvItem class. Add code to the forms to   *
* Team 2 Assignment, 11JUN2022     |    provide for these new classes:                             *
* Patrick McKee & Dominique Tepper |           (1) Plant, (2) Supply                               *
***************************************************************************************************/

namespace InventoryMaintenance
{
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;
        public InvItem() { } 

        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

        public int ItemNo { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


/* *********************************************************************************
* Step 2. Modify the GetDisplayText() method so it's overridable.
* public string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
* *********************************************************************************/
        public virtual string GetDisplayText() => itemNo + "    " + description + " (" + price + ")";


    }
}
