namespace AbstractFactory;

public class RegularCar : ICar
{
    public void DisplayInfo()
    {
        Console.WriteLine("RegularCar : vehicle which is used for regular driving to work");
    }
}
