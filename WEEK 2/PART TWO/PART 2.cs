using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_TWO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string translate1 = "ahoy";
            textBox1.Text = translate1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string translate2 = "Avast";
            textBox2.Text = translate2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string translate3 = "Arr";
            textBox3.Text = translate3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string translate4 = "Matey";
            textBox4.Text = translate4;
        }
    }
}
