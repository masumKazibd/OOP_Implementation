using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    public abstract class vehicle
    {
        public string modelNo { get; set; }
        public int yearMake { get; set; }
        public int noOfGear { get; set; }
        public int engineCapacityCC { get; set; }
    }
}
