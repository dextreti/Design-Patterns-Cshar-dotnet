namespace FluentBuilder;

public class ShoppingCartDirector
{
    public void Construct()
    {
        List<Item> items = new List<Item>(){
        new Item{ Name ="product 1", Price = 125, Quantity=3},
        new Item{ Name ="product 2", Price = 100, Quantity=2}
        };

        ShoppingCart cart =
                      ShoppingCart.Create()
                      .setClient(p => p.WithFirstName("Ricardo").WithLastName("Huerta Dextre"))
                      .AddItem(items)
                      .Checkout()
                      .setDelivery(d => d.WithAddress("Av. Pethituars").WithPostalCode("123"))
                      .setPayment(p => p.WithName("visa").WithSecurityCode("123"))
                      .Process();
        Console.WriteLine(cart.ToString());
    }

}
