namespace Decorator;

public class Pepperoni : PizzaDecorator
{
    public Pepperoni(IPizza pizza) : base(pizza)
    {
    }
    public override void Prepare()
    {
        base.Prepare();
        Console.WriteLine("Adding Pepperoni");
    }
}
