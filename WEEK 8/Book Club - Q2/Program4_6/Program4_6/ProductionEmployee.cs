using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_6
{
    class ProductionEmployee : Employee
    {
        private string hourlyPay;
        private string shiftNumber;

        public ProductionEmployee()
        {

        }

        public ProductionEmployee(string lastName, string firstName, string number, string hourlyPay, string shiftNumber) : base(lastName, firstName, number)
        {
            this.HourlyPay = hourlyPay;
        }

        public string HourlyPay
        {
            get
            {
                return this.hourlyPay;
            }
            set
            {
                this.hourlyPay = value;
            }
        }

        public string ShiftNumber
        {
            get
            {
                return this.shiftNumber;
            }
            set
            {
                if (value.Length <= 1)
                {
                    this.shiftNumber = value;
                }
                else
                {
                    MessageBox.Show("Please enter a valid shift number (1, 2, or 3)!");
                }
                
            }
        }

        public override string GetDisplayText() => base.GetDisplayText() + " Hr: " + this.hourlyPay + " Shift: " + this.shiftNumber;

    }
}
