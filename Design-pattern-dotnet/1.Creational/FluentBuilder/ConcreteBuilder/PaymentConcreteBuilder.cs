namespace FluentBuilder;

public interface IPaymentConcreteFluentBuilder
{
    IPaymentConcreteBuilderName WithName(string name);
}
public interface IPaymentConcreteBuilderName
{
    Payment WithSecurityCode(string code);
}
public class PaymentConcreteBuilder : IPaymentConcreteFluentBuilder, IPaymentConcreteBuilderName
{
    Payment _payment;
    internal PaymentConcreteBuilder()
    {
        _payment = new();
    }

    public IPaymentConcreteBuilderName WithName(string name)
    {
        _payment.Name = name;
        return this;
    }

    public Payment WithSecurityCode(string code)
    {
        _payment.SecurityCode = code;
        return _payment;
    }
}
