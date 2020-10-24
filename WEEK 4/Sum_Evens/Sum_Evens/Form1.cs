using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum_Evens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, n, sum = 0;

            n = double.Parse(txtInteger.Text);

            for (i = 2; i <= n; i += 2)
            {
                sum += i;
            }

            txtResult.Text = sum.ToString("g");

        }
    }
}
