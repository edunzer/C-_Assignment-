using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Truck: Vehicle
    {

        private string bedSize;

        public Truck()
        {

        }

        public Truck(string vin, string description, string purchasePrice, string bedSize) : base(vin, description, purchasePrice)
        {
            this.bedSize = bedSize;
        }

        public string BedSize
        {
            get
            {
                return this.bedSize;
            }
            set
            {
                this.bedSize = value;
            }
        }

        public override string GetDisplayText() => base.GetDisplayText() + " " + this.bedSize;

    }
}
