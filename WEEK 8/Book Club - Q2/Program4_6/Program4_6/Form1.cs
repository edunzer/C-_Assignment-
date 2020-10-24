using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int points = 0;  // points earned each month
            if (n1 == 0)
            {
                points = 0;
            }
            else if (n1 == 1)
            {
                points = 5;
            }
            else if (n1 == 2)
            {
                points = 15;
            }
            else if (n1 == 3)
            {

                points = 30;
            }
            else if (n1 >= 4)
            {
                points = 60;
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
            label3.Text = points.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
