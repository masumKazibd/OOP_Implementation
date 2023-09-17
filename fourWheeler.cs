using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    public abstract class fourWheeler : vehicle, IExteriorDesign
    {
        List<string>Specification=new List<string>();
        public void AddSpecification(string specification)
        {
            Specification.Add(specification);
        }

        public string ShowSpecification()
        {
           return string.Join(", ", Specification);
        }
    }
}
