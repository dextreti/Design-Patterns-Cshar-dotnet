namespace Decorator;

public class PizzaDecorator : IPizza
{
    private readonly IPizza _pizza;
    public PizzaDecorator(IPizza pizza)
    {
        this._pizza = pizza;
    }
    public virtual void Prepare() => _pizza.Prepare();

}
