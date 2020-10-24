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
    public partial class frmVehicleAddNormal : Form
    {
        public frmVehicleAddNormal()
        {
            InitializeComponent();
        }

        private List<Vehicle> vehicles = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddVehicle addVehicleForm = new frmAddVehicle();
            Vehicle vehicle = addVehicleForm.GetNewVehicle();
            if (vehicle != null)
            {
                vehicles.Add(vehicle);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstVehicle.SelectedIndex;
            if (i != -1)
            {
                Vehicle vehicle = vehicles[i];
                string message = "Are you sure you want to delete" + vehicle.VinNumber + " " + vehicle.Description + "?";
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

        private void frmVehicleAddNormal_Load(object sender, EventArgs e)
        {
            vehicles = VehicleDB.GetVehicle();
            FillVehicleListBox();
        }

        private void FillVehicleListBox()
        {
            lstVehicle.Items.Clear();
            foreach (Vehicle v in vehicles)
            {
                lstVehicle.Items.Add(v.GetDisplayText());
            }
        }
    }
}
