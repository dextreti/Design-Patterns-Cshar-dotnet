namespace FluentBuilder;

public interface IDeliveryConcreteFluentBuilder
{
    IDeliveryHasAddress WithAddress(string address);
}
public interface IDeliveryHasAddress
{
    Delivery WithPostalCode(string code);
}
public class DeliveryConcreteBuilder : IDeliveryConcreteFluentBuilder, IDeliveryHasAddress
{

    Delivery _delivery;
    internal DeliveryConcreteBuilder()
    {
        _delivery = new();
    }

    public IDeliveryHasAddress WithAddress(string address)
    {
        _delivery.Address = address;
        return this;
    }

    public Delivery WithPostalCode(string code)
    {
        _delivery.PostalCode = code;
        return _delivery;
    }
}
