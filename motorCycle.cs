using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    public sealed class motorCycle:TwoWheeler
    {
        public motorCycle()
        {
            
        }
        public motorCycle(int maxPower, int maximumTorque, string startingMethod, double mileage, string cooling,
            string frontBrake, string rearBrake,string modelNo,int yearMake,
            int noOfGear,int engineCapacityCC)
        {
            this.modelNo = modelNo;
            this.yearMake = yearMake;
            this.noOfGear = noOfGear;
            this.engineCapacityCC = engineCapacityCC;
            this.maxPower = maxPower;
            this.maximumTorque = maximumTorque;
            this.startingMethod = startingMethod;
            this.mileage = mileage;
            this.cooling = cooling;
            this.frontBrake = frontBrake;
            this.rearBrake = rearBrake;
        }

        public int maxPower { get; set; }
        public int maximumTorque { get; set; }
        public string startingMethod { get; set; }
        public double mileage { get; set; }
        public string cooling { get; set; }
        public string frontBrake { get; set; }
        public string rearBrake { get; set; }



    }
}
