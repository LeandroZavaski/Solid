using System;

namespace Ocp.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcicle();
        }

        public void ConfigureMotorcicle()
        {
            Console.WriteLine($"Criando um carro {Color}, {Year}, {Engine} cilindradas!");
            StartVehicle();
        }
    }
}
