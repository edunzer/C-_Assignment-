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

        decimal[] points = new decimal[6];
        byte i = 0;

        public void calculate()
        {
            int n1 = int.Parse(txtInput.Text);
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
            txtPoints.Text = points.ToString();

            try
            {
                this.points[i] = points;
                i++;
            }
            catch
            {
                MessageBox.Show("Invoice limit reached. Please restart the application before entering more invoices", "Array Limit");
            }

            decimal total = GetTotal();
            txtPoints.Text = total.ToString("");
        }

        

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (decimal p in points)
                total += p;
            return total;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string displayPoints = "Book club points: \r";
            foreach (decimal p in points)
            {
                if (p != 0)
                {
                    displayPoints += "\r";
                    displayPoints += p.ToString("");
                }
            }

            MessageBox.Show(displayPoints, "Points Calculated");

            this.Close();
        }
    }
}
