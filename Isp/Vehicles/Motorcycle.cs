using System;

namespace Isp.Vehicles
{
    public class Motorcycle : IVehicleMotorcycle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorCycle(color, year, engine);
        }

        public void ConfigureMotorCycle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;

            Console.WriteLine($"Criando moto ano {Year}, motor {Engine} cilindradas da cor {Color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
