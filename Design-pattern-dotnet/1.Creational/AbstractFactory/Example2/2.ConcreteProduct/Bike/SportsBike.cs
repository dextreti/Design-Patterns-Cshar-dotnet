namespace AbstractFactory;

public class SportsBike : IBike
{
    public void DisplayInfo()
    {
        Console.WriteLine("SportsBike: Sport bikes are road bikes that emphasize top speed, acceleration, braking, handling and grip, typically at the expense of comfort and fuel economy");
    }
}
