using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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

        decimal[] prices = new decimal[5];
        byte i = 0;

        

        public void calculate()
        {
            try
            {
                if (IsValidData())
                {
                    decimal originalPrice, discountPercentage, discountAmount, salePrice;

                    originalPrice = decimal.Parse(txtWholesale.Text);
                    discountPercentage = decimal.Parse(txtPercentage.Text);

                    discountPercentage = discountPercentage / 100;

                    discountAmount = originalPrice * discountPercentage;
                    salePrice = originalPrice - discountAmount;

                    txtPrice.Text = salePrice.ToString("c");

                    try
                    {
                        prices[i] = salePrice;
                        i++;
                    }
                    catch
                    {
                        MessageBox.Show("Invoice limit reached. Please restart the application before entering more invoices", "Array Limit");
                    }

                    decimal average = GetAverage();
                    txtAverage.Text = average.ToString("c");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        public bool IsValidData()
        {
            return
                IsPresent(txtWholesale, "Wholesale cost") &&
                IsDecimal(txtWholesale, "Wholesale cost") &&
                IsWithinRange(txtWholesale, "Wholesale cost", 0, 100000) &&

                IsPresent(txtPercentage, "Markup Percentage") &&
                IsDecimal(txtPercentage, "Markup Percentage") &&
                IsWithinRange(txtPercentage, "Markup Percentage", 0, 100);

                
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + "must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private decimal GetAverage()
        {
            decimal average = 0;
            foreach(decimal p in prices)
                average += p;
                average /= i;
                return average;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string displayPrices = "Retail prices: \r";
            foreach(decimal p in prices)
            {
                if (p != 0)
                {
                    displayPrices += "\r";
                    displayPrices += p.ToString("C");
                }
            }

            MessageBox.Show(displayPrices, "Prices Calculated");

            this.Close();
        }
    }
}
