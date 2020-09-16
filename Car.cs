using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassOPPs
{
    class Car:Vehicle
    {
        public string Make = "Ford";
       public string Name =  "Mustang";
        public int Model_year =2014;
        public int Number_of_doors = 4;
        public void myCar()
        {
            Console.WriteLine("My Car Details :");
        }

    }
}
