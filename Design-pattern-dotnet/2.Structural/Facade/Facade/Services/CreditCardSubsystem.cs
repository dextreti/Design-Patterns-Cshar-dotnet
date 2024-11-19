namespace Facade;

class CreditCardSubsystem
{
    public void IssueCreditCard(string accountHolder)
    {
        Console.WriteLine($"Emisión de tarjeta de crédito para {accountHolder}");
    }

    public void MakePurchase(string accountHolder, decimal amount)
    {
        Console.WriteLine($"Realizando compra con tarjeta de crédito de {accountHolder} por {amount:C}");
    }
}