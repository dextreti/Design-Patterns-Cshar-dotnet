
namespace Builder;

public class ConcreteBuilderBurger : BuilderBurger
{
    private readonly Burger burger;

    public ConcreteBuilderBurger()
    {
        burger = new();
    }

    //public static ConcreteBuilderBurger Create() => new();

    public override Burger build()
    {
        return burger;
    }

    public override BuilderBurger withCheese()
    {
        burger.Cheese = true;
        return this;
    }

    public override BuilderBurger withDip()
    {
        burger.Dip = true;
        return this;
    }

    public override BuilderBurger withLetture()
    {
        burger.Lettuce = true;
        return this;
    }

    public override BuilderBurger withOnion()
    {
        burger.Onion = true;
        return this;
    }

    public override BuilderBurger withTomato()
    {
        burger.Tomato = true;
        return this;
    }
}
