using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_TERM_QUESTION1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GetLetter()
        {
            decimal numberGrade = Convert.ToDecimal(txtEnter.Text);
            char letter = 'F';


            if (numberGrade >= 90 && numberGrade <= 100)
            {
                letter = 'A';
                txtResult.Text = "A";
            }

            else if (numberGrade >= 80 && numberGrade < 90)
            {
                letter = 'B';
                txtResult.Text = "B";
            }
            else if (numberGrade >= 70 && numberGrade < 80)
            {
                letter = 'C';
                txtResult.Text = "C";
            }
            else if (numberGrade >= 60 && numberGrade < 70)
            {
                letter = 'D';
                txtResult.Text = "D";
            }
            else
            {
                letter = 'D';
                txtResult.Text = "F";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetLetter();
        }
    }
}
