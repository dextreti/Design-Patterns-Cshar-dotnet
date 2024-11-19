using System.Text;

namespace FluentBuilder;

public class ShoppingCart
{

    public static IShoppingCartFluentBuilder Create()
    {
        var _builder = new ShoppingCartConcreteBuilder();
        return _builder;
    }

    List<Item> _items;
    public Payment Payment { get; internal set; }
    public Delivery Delivery { get; internal set; }
    public Client Client { get; internal set; }

    internal ShoppingCart()
    {
        _items = new();

    }

    internal void AddItem(IEnumerable<Item> items)
    {
        _items.AddRange(items);
    }


    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("\n Client:");
        builder.Append("\n FirstName: " + Client.FirstName);
        builder.Append("\n LastName: " + Client.LastName);

        builder.Append("\n Product:");
        _items.ForEach(p =>
        {
            builder.Append("\n Name: " + p.Name);
            builder.Append("\n Price: " + p.Price);
            builder.Append("\n Quantity: " + p.Quantity);
        });

        builder.Append("\n Delivery:");
        builder.Append("\n Address: " + Delivery.Address);
        builder.Append("\n PostalCode: " + Delivery.PostalCode);

        builder.Append("\n Payment:");
        builder.Append("\n CardPay: " + Payment.Name);
        builder.Append("\n PostalCode: " + Delivery.PostalCode);

        return builder.ToString();
    }

}
