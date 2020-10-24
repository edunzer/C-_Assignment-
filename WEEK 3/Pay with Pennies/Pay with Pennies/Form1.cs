using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_with_Pennies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Local variables. /
            int daysWorkedInputValue;
            double currentPayRate, totalPaySalary;

            int daysWorked;

            currentPayRate = 0.01;
            totalPaySalary = 0;

            daysWorkedInputValue = int.Parse(txtEnter.Text);

            if (int.TryParse(txtEnter.Text, out daysWorked))
            {
                if (daysWorked >= 0)
                {
                    int numberPower = daysWorked;
                    int numberBase = 2;

                    totalPaySalary = currentPayRate * (Math.Pow(numberBase, daysWorked));

                    txtTotal.Text = totalPaySalary.ToString("c");
                }
            }
        }
    }
}
