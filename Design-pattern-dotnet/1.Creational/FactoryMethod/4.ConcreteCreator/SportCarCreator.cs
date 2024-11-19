namespace AbstractFactory;

public class SportCarCreator : ICarCreator
{

    public ICar FactoryMethod()
    {
        return new SportCar();
    }
}
