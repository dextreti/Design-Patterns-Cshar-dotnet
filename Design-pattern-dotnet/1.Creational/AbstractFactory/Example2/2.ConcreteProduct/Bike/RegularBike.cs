namespace AbstractFactory;

public class RegularBike : IBike
{
    public void DisplayInfo()
    {
        Console.WriteLine("RegularBike : casual bikes are road bikes that emphasize not top speed, typically is not expense");
    }
}
