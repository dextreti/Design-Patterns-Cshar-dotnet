
namespace FluentBuilder;

public class ShoppingCartConcreteBuilder : IShoppingCartFluentBuilder, IClientFluentBuilder, IItemFluentBuilder, IDeliveryFluentBuilder, IPaymentFluentBuilder, IBuilder<ShoppingCart>
{
    ShoppingCart _cart;
    internal ShoppingCartConcreteBuilder()
    {
        _cart = new();
    }

    public IItemFluentBuilder AddItem(List<Item> items)
    {
        _cart.AddItem(items);
        return this;
    }

    public IPaymentFluentBuilder Checkout()
    {
        return this;
    }

    public IClientFluentBuilder setClient(Func<IClientConcreteFluentBuilder, Client> clientConfig)
    {
        _cart.Client = clientConfig.Invoke(new ClientConcreteBuilder());
        return this;

    }

    public IDeliveryFluentBuilder setDelivery(Func<IDeliveryConcreteFluentBuilder, Delivery> deliveryConfigurator)
    {
        _cart.Delivery = deliveryConfigurator.Invoke(new DeliveryConcreteBuilder());
        return this;
    }

    public IPaymentFluentBuilder setPayment(Func<IPaymentConcreteFluentBuilder, Payment> paymentConfigurator)
    {
        _cart.Payment = paymentConfigurator.Invoke(new PaymentConcreteBuilder());
        return this;
    }

    public ShoppingCart Process()
    {
        return _cart;
    }

    IItemFluentBuilder IItemFluentBuilder.Checkout()
    {
        return this;
    }
}
