namespace AbstractFactory;

public class SportsVehicleFactory : IVehicleFactory
{
    public IBike CreateBike()
    {
        return new SportsBike();
    }

    public ICar CreateCar()
    {
        return new SportCar();
    }
}
