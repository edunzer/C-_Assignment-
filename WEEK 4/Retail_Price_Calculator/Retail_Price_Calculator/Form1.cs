using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            double originalPrice, discountPercentage, discountAmount, salePrice;

            originalPrice = double.Parse(txtWholesale.Text);
            discountPercentage = double.Parse(txtPercentage.Text);

            discountPercentage = discountPercentage / 100;

            discountAmount = originalPrice * discountPercentage;
            salePrice = originalPrice - discountAmount;

            txtPrice.Text = salePrice.ToString("c");
        }
    }
}
