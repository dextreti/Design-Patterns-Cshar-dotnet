namespace AbstractFactory;

public interface IVehicleFactory
{
    IBike CreateBike();
    ICar CreateCar();

}
