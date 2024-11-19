namespace Decorator;

public class Barbecue : PizzaDecorator
{
    public Barbecue(IPizza pizza) : base(pizza)
    {
    }

    public override void Prepare()
    {
        base.Prepare();
        Console.WriteLine("Adding Barbecue");
    }
}
