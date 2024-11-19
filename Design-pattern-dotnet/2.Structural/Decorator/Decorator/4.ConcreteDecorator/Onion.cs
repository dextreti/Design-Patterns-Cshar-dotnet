namespace Decorator;

public class Onion : PizzaDecorator
{
    public Onion(IPizza pizza) : base(pizza)
    {
    }
    public override void Prepare()
    {
        base.Prepare();
        Console.WriteLine("Adding Onion");
    }
}
