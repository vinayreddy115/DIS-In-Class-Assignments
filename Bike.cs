using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassOPPs
{
    class Bike:Vehicle
    {
        public string Make = "Pulsar";
        public string Type = "220F";
        public int Number_of_gears = 5;
        public void myBike()
        {
            Console.WriteLine("My Bike Details :");
        }
    }
}
