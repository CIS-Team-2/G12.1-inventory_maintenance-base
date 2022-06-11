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
    public class InvItemList
    {
        private List<InvItem> invItems;

        public delegate void ChangeHandler(InvItemList invItems);
        public event ChangeHandler Changed;

        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;

        public InvItem this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i > invItems.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return invItems[i];
            }
            set
            {
                invItems[i] = value;
                Changed(this);
            }
        }

        //public InvItem GetItemByIndex(int i) => invItems[i];

        public void Add(InvItem invItem)
        {
            invItems.Add(invItem);
            Changed(this);
        }

        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);
            Changed(this);
        }

        public void Remove(InvItem invItem)
        {
            invItems.Remove(invItem);
            Changed(this);
        }

        public static InvItemList operator +(InvItemList il, InvItem i)
        {
            il.Add(i);
            return il;
        }

        public static InvItemList operator -(InvItemList il, InvItem i)
        {
            il.Remove(i);
            return il;
        }

        public void Fill() => invItems = InvItemDB.GetItems();

        public void Save() => InvItemDB.SaveItems(invItems);
    }
}
