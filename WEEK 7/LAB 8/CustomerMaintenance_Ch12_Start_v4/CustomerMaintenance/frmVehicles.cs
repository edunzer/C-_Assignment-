using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmVehicles : Form
    {
        public frmVehicles()
        {
            InitializeComponent();
        }

        private List<Vehicle> vehicles = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddVehicle addCustomerForm = new frmAddVehicle();
            Vehicle vehicle = addCustomerForm.GetNewVehicle();
            if (vehicle != null)
            {
                vehicles.Add(vehicle);
                VehicleDB.SaveVehicle(vehicles);
                FillVehicleListBox();
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            vehicles = VehicleDB.GetVehicles();
            FillVehicleListBox();
        }

        private void FillVehicleListBox()
        {
            lstVehicles.Items.Clear();
            foreach(Vehicle c in vehicles)
            {
                lstVehicles.Items.Add(c.GetDisplayText());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstVehicles.SelectedIndex;
            if (i != -1)
            {
                Vehicle vehicle = vehicles[i];
                string message = "Are you sure you want to delete " + vehicle.Vin + " " + vehicle.Description + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    vehicles.Remove(vehicle);
                    VehicleDB.SaveVehicle(vehicles);
                    FillVehicleListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}