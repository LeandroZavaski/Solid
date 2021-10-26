using Ocp.Vehicles;
using System;

// Open/Closed principle
namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = TypeVehicle.MOTORCICLE;

            if (type == TypeVehicle.CAR)
            {
                var vehicle = new Car("Azul", 2022, 2.0, 5, 4);
            }
            else
            {
                var vehicle = new Motorcycle("Branca", 2022, 250);
            }

            Console.ReadLine();
        }
    }
}
