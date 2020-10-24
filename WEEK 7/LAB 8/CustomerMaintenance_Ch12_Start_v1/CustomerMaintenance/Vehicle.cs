using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Vehicle
    {
        private string vinNumber;
        private string description;
        private string purchasePrice;
        private string numberOfDoors;
        private string bedType;

        public Vehicle()
        {

        }

        public Vehicle(string vinNumber, string description, string purchasePrice, string numberOfDoors, string bedType)
        {
            this.VinNumber = vinNumber;
            this.Description = description;
            this.PurchasePrice = purchasePrice;
            this.NumberOfDoors = numberOfDoors;
            this.BedType = bedType;
        }

        public string VinNumber
        {
            get
            {
                return vinNumber;
            }
            set
            {
                vinNumber = value;
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

        public string BedType
        {
            get
            {
                return bedType;
            }
            set
            {
                bedType = value;
            }
        }

        public string GetDisplayText() => vinNumber + " " + description + " " + purchasePrice + " " + numberOfDoors + " " + bedType;

    }

}
