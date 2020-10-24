using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_TERM_QUESTION2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SumNumbers()
        {
            double i, n, sum = 0;

            n = double.Parse(txtInteger.Text);

            for (i = 5; i <= n; i += 5)
            {
                sum += i;
            }

            txtResult.Text = sum.ToString("g");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SumNumbers();
        }
    }
}
