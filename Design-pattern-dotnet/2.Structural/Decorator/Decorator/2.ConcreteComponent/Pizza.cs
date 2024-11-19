namespace Decorator;

public class Pizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Pizza normal");
    }
}
