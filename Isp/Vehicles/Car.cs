using System;

namespace Isp.Vehicles
{
    public class Car : IVehicleCar
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }


        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;

            Console.WriteLine($"Criando carro ano {Year}, motor {Engine} da cor {Color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
