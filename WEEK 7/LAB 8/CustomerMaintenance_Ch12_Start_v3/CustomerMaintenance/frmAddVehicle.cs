using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmAddVehicle : Form
    {
        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private Vehicle vehicle = null;

        public Vehicle GetNewVehicle()
        {
            this.ShowDialog();
            return vehicle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (chkCar.Checked && chkTruck.Checked)
            {
                MessageBox.Show("Sorry you cant select both car and truck. Please select 1.");
            }
            else if (chkCar.Checked || chkTruck.Checked)
            {
                if (IsValidData())
                {
                    vehicle = new Vehicle(txtVin.Text, txtDescription.Text, txtPurchasePrice.Text, txtNumberOfDoors.Text, txtBedSize.Text);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select your vehicle type to continue.");
            }
            
        }

        private bool IsValidData()
        {
            if (chkCar.Checked)
            {
                return Validator.IsInt32(txtVin) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsInt32(txtPurchasePrice) &&
                Validator.IsInt32(txtNumberOfDoors);
            }
            else
            {
                return Validator.IsInt32(txtVin) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsInt32(txtPurchasePrice) &&
                Validator.IsPresent(txtBedSize);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkCar_CheckedChanged(object sender, EventArgs e)
        {
            txtNumberOfDoors.Visible = chkCar.Checked;
            lbNumberOfDoors.Visible = chkCar.Checked;
            
        }

        private void chkTruck_CheckedChanged(object sender, EventArgs e)
        {
            txtBedSize.Visible = chkTruck.Checked;
            lbBedSize.Visible = chkTruck.Checked;
        }
    }
}