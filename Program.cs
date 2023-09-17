using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int temp = 0;
                while (temp == 0)
                {
                    Console.Write("Which information do you want :\n[Hints]\n1.Car\n2.MotorCycle" +
                        "\nEnter Selected No\t: ");
                    vehicleType vehicleType = (vehicleType)int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("*********************************");
                    Console.WriteLine();
                    if (vehicleType == (vehicleType)1 || vehicleType == (vehicleType)2)
                    {
                        if (vehicleType == (vehicleType)1)
                        {
                            CarInfo();
                        }
                        else
                        {
                            MotorCycleInfo();
                        }
                        temp = 1;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter Correct no :");
                        temp=0;
                    }

                }
            }
            catch
            {
                throw;
            }
            Console.ReadKey();
        }
        
        private static void CarInfo()
        {
            Console.Write("Model No\t: ");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make\t: ");
            int yearMake = int.Parse(Console.ReadLine());

            Console.Write("Number Of Seats\t: ");
            int numberOfSeats = int.Parse(Console.ReadLine());

            Console.Write("Number Of Gear\t: ");
            int noOfGear = int.Parse(Console.ReadLine());

            Console.Write("Number Of Door\t: ");
            int numberOfDoor = int.Parse(Console.ReadLine());

            Console.Write("Engine Capacity In CC\t: ");
            int engineCapacityCC = int.Parse(Console.ReadLine());

            Console.Write("Steering System\t: ");
            string steeringSystem = Console.ReadLine();

            car c = new car(numberOfSeats,numberOfDoor,steeringSystem,modelNo,yearMake,noOfGear,
                engineCapacityCC);

            string specification = "";
            while (specification.ToLower() != "0")
            {
                Console.Write("Add Interior Design [press o to stop]\t: ");
                specification= Console.ReadLine();
                if(specification.ToLower()!="0" ) 
                {
                    c.AddSpecification(specification);
                }
            }
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine($"Model no\t:{modelNo}");
            Console.WriteLine($"Year Make\t:{yearMake}");
            Console.WriteLine($"Number Of Seats\t:{numberOfSeats}");
            Console.WriteLine($"Number Of Gear\t:{noOfGear}");
            Console.WriteLine($"Number Of Door\t:{numberOfDoor}");
            Console.WriteLine($"Engine Capacity In CC\t:{engineCapacityCC}");           
            Console.WriteLine($"Steering System\t:{steeringSystem}");
            Console.WriteLine($"Exterior Design\t:{c.ShowSpecification()}");
            Console.WriteLine("*********************************");
        }

        private static void MotorCycleInfo()
        {
            Console.Write("Model No\t: ");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make\t: ");
            int yearMake = int.Parse(Console.ReadLine());

            Console.Write("Number Of Gear\t: ");
            int noOfGear = int.Parse(Console.ReadLine());

            Console.Write("Starting Method\t: ");
            string startingMethod = (Console.ReadLine());

            Console.Write("Engine Capacity In CC\t: ");
            int engineCapacityCC = int.Parse(Console.ReadLine());

            Console.Write("Maximum power In BPH\t: ");
            int maxPower = int.Parse(Console.ReadLine());

            Console.Write("Maximum Torque in NM\t: ");
            int maximumTorque = int.Parse(Console.ReadLine());

            Console.Write("Mileage in KMPL\t: ");
            int mileage = int.Parse(Console.ReadLine());

            Console.Write("Cooling\t: ");
            string cooling = Console.ReadLine();

            Console.Write("Front Brake\t: ");
            string frontBrake = Console.ReadLine();

            Console.Write("Rear Brake\t: ");
            string rearBrake = Console.ReadLine();

            motorCycle m = new motorCycle(maxPower, maximumTorque, startingMethod, mileage, cooling, frontBrake, rearBrake, modelNo, yearMake, noOfGear, engineCapacityCC);
            string specification = "";
            while (specification.ToLower() != "0")
            {
                Console.Write("Add Exterior Design[press 0 to stop]\t: ");
                specification = Console.ReadLine();
                if (specification.ToLower() != "0")
                {
                    m.AddSpecification(specification);
                }
            }
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine($"Model no\t:{modelNo}");
            Console.WriteLine($"Year Make\t:{yearMake}");
            Console.WriteLine($"Number Of Gear\t:{noOfGear}");
            Console.WriteLine($"starting Method\t:{startingMethod}");
            Console.WriteLine($"Engine Capacity In CC\t:{engineCapacityCC}");
            Console.WriteLine($"Maximum power In BPH\t:{maxPower}");
            Console.WriteLine($"Maximum Torque In NM\t:{maximumTorque}");
            Console.WriteLine($"Mileage In KMPL\t:{mileage}");
            Console.WriteLine($"Cooling\t:{cooling}");
            Console.WriteLine($"Front Brake\t:{frontBrake}");
            Console.WriteLine($"Rear Brake\t:{rearBrake}");
            Console.WriteLine($"Exterior Design\t:{m.ShowSpecification()}");
            Console.WriteLine("*********************************");

        }
    }
}
