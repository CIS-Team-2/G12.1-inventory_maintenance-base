using System;
using System.Collections.Generic;
using System.Text;

/***************************************************************************************************
* CIS 123: Introduction to OOP     |    Exercise 14-1 Use inheritance                              
* Murach's C#, 7th Edition         |    Add 2 classes to the Inventory Maintenance application     
* Chapter 14 Extra Exercises       |    that inherit the InvItem class. Add code to the forms to   
* Team 2 Assignment, 11JUN2022     |    provide for these new classes:                             
* Patrick McKee & Dominique Tepper |           (1) Plant, (2) Supply                               
* --------------------------------------------------------------------------------------------------
*
* Step 4. Add a class named Supply that inherits the InvItem class.
*      a. Add a string property named Manufacturer
*      b. Provide a default constructor
*      c. Provide a contructor that accepts 4 parameters to initialize properties
*         defined by the class:
*            i. item number
*           ii. description
*          iii. price
*           iv. manufacturer
*           
*      d. Override the GetDisplayText() method to add the size in front of
*         the description - 
*          9210584    Ortho Snail pellets ($12.95)
 * *************************************************************************************************/

namespace InventoryMaintenance
{
    internal class Supply
    {
    }
}
