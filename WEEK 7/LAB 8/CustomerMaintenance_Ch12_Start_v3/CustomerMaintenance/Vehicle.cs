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
        private string numberOfDoors;
        private string bedSize;

        public Vehicle()
        {

        }

        public Vehicle (string vin, string description, string purchasePrice, string numberOfDoors, string bedSize)
        {
            this.Vin = vin;
            this.Description = description;
            this.PurchasePrice = purchasePrice;
            this.NumberOfDoors = numberOfDoors;
            this.BedSize = bedSize;
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

        public string NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                numberOfDoors = value;
            }
        }

        public string BedSize
        {
            get
            {
                return bedSize;
            }
            set
            {
                bedSize = value;
            }
        }

        public string GetDisplayText() => vin + " " + description + ", " + purchasePrice + " " + numberOfDoors + " " + bedSize;
    }
}
