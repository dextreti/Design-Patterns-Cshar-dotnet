namespace FluentBuilder;

public interface IShoppingCartFluentBuilder
{
    IClientFluentBuilder setClient(Func<IClientConcreteFluentBuilder, Client> clientCongig);
}
public interface IClientFluentBuilder
{
    IItemFluentBuilder AddItem(List<Item> items);
}
public interface IItemFluentBuilder
{
    IItemFluentBuilder Checkout();
    IDeliveryFluentBuilder setDelivery(Func<IDeliveryConcreteFluentBuilder, Delivery> deliveryConfigurator);
}

public interface IDeliveryFluentBuilder
{
    IPaymentFluentBuilder setPayment(Func<IPaymentConcreteFluentBuilder, Payment> paymentConfigurator);
}
public interface IPaymentFluentBuilder
{
    ShoppingCart Process();
}

