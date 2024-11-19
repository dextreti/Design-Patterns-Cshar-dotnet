namespace AbstractFactory;

public class RegularVehicleFactory : IVehicleFactory
{
    public IBike CreateBike()
    {
        return new RegularBike();
    }

    public ICar CreateCar()
    {
        return new RegularCar();
    }
}
