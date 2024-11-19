
namespace Builder;

public abstract class BuilderBurger : Builder<Burger>
{
    public abstract BuilderBurger withLetture();
    public abstract BuilderBurger withCheese();
    public abstract BuilderBurger withTomato();
    public abstract BuilderBurger withDip();
    public abstract BuilderBurger withOnion();

}
