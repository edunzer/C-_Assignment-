using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Stay_Costs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal DailyCost, OtherCharges, TotalCharges;

            if (txtPreapproved.Text == "yes")
            {
                DailyCost = 200;
            }
            else
            {
                DailyCost = 500;
            }

            decimal NumberOfHospitalDays = Convert.ToDecimal(txtNumberofdays.Text);
            decimal MedicationChargers = Convert.ToDecimal(txtMedication.Text);
            decimal SurgicalCharges = Convert.ToDecimal(txtSurgical.Text);
            decimal LabFees = Convert.ToDecimal(txtLab.Text);
            decimal RehabCharges = Convert.ToDecimal(txtRehab.Text);


            OtherCharges = MedicationChargers + SurgicalCharges + LabFees + RehabCharges;
            TotalCharges = OtherCharges + (NumberOfHospitalDays * DailyCost);

            txtTotal.Text = TotalCharges.ToString("c");
        }
    }
}
