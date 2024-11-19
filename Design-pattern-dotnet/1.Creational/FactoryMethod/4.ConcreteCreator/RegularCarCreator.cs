namespace AbstractFactory;

public class RegularCarCreator : ICarCreator
{

    public ICar FactoryMethod()
    {
        return new RegularCar();
    }
}
