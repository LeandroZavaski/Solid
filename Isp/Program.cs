using Isp.Vehicles;
using System;

// Interface Segregation Principle
namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("", 2022, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("", 2022, 600);

            Console.ReadLine();
        }
    }
}
