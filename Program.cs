using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassOPPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
            Car myCar = new Car(); 
            Bike mybike = new Bike();

            myCar.MyVehicle();
            Console.WriteLine(" ");
            myCar.myCar();
            
            Console.WriteLine(myCar.Make +"  " + myCar.Model_year + "  " + myCar.Name + "  " + myCar.color);
            Console.WriteLine(" ");
            mybike.myBike();
            Console.WriteLine( mybike.Make + "  " + mybike.Number_of_gears + "  " + mybike.color);
            Console.WriteLine(" ");

        }
    }
}
