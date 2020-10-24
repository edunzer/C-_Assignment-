using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            output.Text = "Jack of Hearts";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            output.Text = "Ace of Spades";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            output.Text = "8 of Diamonds";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            output.Text = "2 of Clubs";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            output.Text = "9 of Spades";
        }
    }
}
