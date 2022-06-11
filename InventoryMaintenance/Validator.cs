using System;
using System.Collections.Generic;
using System.Text;
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
	public static class Validator
	{
		private static string title = "Entry Error";
		public static string Title
		{
			get => title;
			set => title = value;
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsDecimal(TextBox textBox)
		{
			decimal number = 0m;
			if (Decimal.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
				textBox.Focus();
				return false;
			}
		}

		public static bool IsInt32(TextBox textBox)
		{
			int number = 0;
			if (Int32.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be an integer.", Title);
				textBox.Focus();
				return false;
			}
		}

		public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}
	}
}
