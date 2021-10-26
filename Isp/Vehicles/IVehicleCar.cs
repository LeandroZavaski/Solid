namespace Isp.Vehicles
{
    public interface IVehicleCar : IVehicles
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
