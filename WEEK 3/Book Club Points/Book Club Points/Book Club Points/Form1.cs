using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Club_Points
{
    public partial class Form1 : Form
    {
        int numOfBooks;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                numOfBooks = int.Parse(txtEnter.Text);
                if (numOfBooks == 0)
                {
                    this.txtPoints.Text += ("You have zero points");
                     
                }
                if (numOfBooks == 1)
                {
                    this.txtPoints.Text += ("You have 5 points");
                }
                if (numOfBooks == 2)
                {
                    this.txtPoints.Text += ("You have 15 points");
                }
                if (numOfBooks == 3)
                {
                    this.txtPoints.Text += ("You have 30 points");
                }
                if (numOfBooks >= 4)
                {
                    this.txtPoints.Text += ("You have 60 points");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a valid number");
            }

        }
    }
}
