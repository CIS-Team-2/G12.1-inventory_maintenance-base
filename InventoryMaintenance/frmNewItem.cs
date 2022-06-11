using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        private InvItem invItem = null;

        public InvItem GetNewItem()
        {
            LoadComboBox();
            this.ShowDialog();
            return invItem;
        }

        private void LoadComboBox()
        {
            cboSizeOrManufacturer.Items.Clear();
            if (rdoPlant.Checked)
            {
                cboSizeOrManufacturer.Items.Add("1 gallon");
                cboSizeOrManufacturer.Items.Add("5 gallon");
                cboSizeOrManufacturer.Items.Add("15 gallon");
                cboSizeOrManufacturer.Items.Add("24-inch box");
                cboSizeOrManufacturer.Items.Add("36-inch box");
            }
            else
            {
                cboSizeOrManufacturer.Items.Add("Bayer");
                cboSizeOrManufacturer.Items.Add("Jobe's");
                cboSizeOrManufacturer.Items.Add("Ortho");
                cboSizeOrManufacturer.Items.Add("Roundup");
                cboSizeOrManufacturer.Items.Add("Scotts");
            }
        }
/* *************************************************************************************
 * Step 5. Modify the event handler for the click event of the Save button on the
 *         new item form so it creates a new item of the appropriate type using
 *         the data entered by the user.
 * 
 * -- McKee & Tepper, 11JUN2022
 * ************************************************************************************/
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (rdoPlant.Checked)
                    invItem = new Plant(
                        Convert.ToInt32(txtItemNo.Text),
                        cboSizeOrManufacturer.Text,
                        txtDescription.Text,
                        Convert.ToInt32(txtPrice.Text));

                else
                    invItem = new Supply(
                        Convert.ToInt32(txtItemNo.Text),
                        cboSizeOrManufacturer.Text,
                        txtDescription.Text,
                        Convert.ToInt32(txtPrice.Text));

                /*invItem = new InvItem(
                    Convert.ToInt32(txtItemNo.Text),
                    txtDescription.Text, 
                    Convert.ToDecimal(txtPrice.Text)*/

                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoPlant_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPlant.Checked)
            {
                lblSizeOrManufacturer.Text = "Size:";
            }
            else
            {
                lblSizeOrManufacturer.Text = "Manufacturer:";
            }
            LoadComboBox();
        }
    }
}
