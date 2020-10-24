using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK1_ASSIGNMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal item1 = Decimal.Parse(txtItem1.Text);
            decimal item2 = Decimal.Parse(txtItem2.Text);
            decimal item3 = Decimal.Parse(txtItem3.Text);

            decimal calculate = (item1 + item2 + item3) / 3;
            txtCalculate.Text = calculate.ToString("c");


        }
    }
}
