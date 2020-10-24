using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Vehicle
    {
        private string vin;
        private string description;
        private string purchasePrice;
        

        public Vehicle()
        {

        }

        public Vehicle (string vin, string description, string purchasePrice, string numberOfDoors, string bedSize)
        {
            this.Vin = vin;
            this.Description = description;
            this.PurchasePrice = purchasePrice;
            
        }

        public string Vin
        {
            get
            {
                return vin;
            }
            set
            {
                vin = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string PurchasePrice
        {
            get
            {
                return purchasePrice;
            }
            set
            {
                purchasePrice = value;
            }
        }

        

        public virtual string GetDisplayText() => vin + " " + description + ", " + purchasePrice;
    }
}
