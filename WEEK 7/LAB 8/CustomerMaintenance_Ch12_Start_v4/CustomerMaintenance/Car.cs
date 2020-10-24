using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Car: Vehicle
    {

        private string numberOfDoors;

        public Car()
        {

        }

        public Car(string vin, string description, string purchasePrice, string numberOfDoors) : base(vin, description, purchasePrice)
        {
            this.numberOfDoors = numberOfDoors;
        }

        public string NumberOfDoors
        {
            get
            {
                return this.numberOfDoors;
            }
            set
            {
                this.numberOfDoors = value;
            }
        }

        public override string GetDisplayText() => base.GetDisplayText() + " " + this.numberOfDoors;

    }
}
