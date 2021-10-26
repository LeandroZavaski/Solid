using System;

namespace Ocp.Vehicles
{
    public class Vehicle : IVehicles
    {
        protected string Color { get; set; }
        protected int Year { get; set; }
        protected double Engine { get; set; }

        public Vehicle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
