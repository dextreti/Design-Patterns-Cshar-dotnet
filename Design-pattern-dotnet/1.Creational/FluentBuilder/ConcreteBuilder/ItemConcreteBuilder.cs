namespace FluentBuilder;

public interface ItemConcreteFluentBuilder
{
    ItemConcreteBuilderName WithName(string name);
}
public interface ItemConcreteBuilderName
{
    ItemConcreteBuilderPrice WithPrice(double price);
}
public interface ItemConcreteBuilderPrice
{
    Item WithQuantity(int quantity);
}
public class ItemConcreteBuilder : ItemConcreteFluentBuilder, ItemConcreteBuilderName, ItemConcreteBuilderPrice
{
    Item _item;
    internal ItemConcreteBuilder()
    {
        _item = new();
    }

    public ItemConcreteBuilderName WithName(string name)
    {
        _item.Name = name;
        return this;
    }

    public ItemConcreteBuilderPrice WithPrice(double price)
    {
        _item.Price = price;
        return this;
    }

    public Item WithQuantity(int quantity)
    {
        _item.Quantity = quantity;
        return _item;
    }
}
