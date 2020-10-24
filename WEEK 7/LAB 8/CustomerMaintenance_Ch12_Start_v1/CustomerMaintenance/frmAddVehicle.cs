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
            vehicle = new Vehicle(txtVIN.Text, txtDescription.Text, txtPurchasePrice.Text, txtDoors.Text, txtBedtype.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}