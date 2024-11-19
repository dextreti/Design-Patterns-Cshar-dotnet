namespace Facade;

public class AccountSubsystem
{

    public void Create(string accountHolder, decimal initialBalance)
    {
        Console.WriteLine($"Creando cuenta bancaria para {accountHolder} con saldo inicial: {initialBalance:C}");
    }

    public void Deposit(string accountHolder, decimal amount)
    {
        Console.WriteLine($"Depósito de {amount:C} en la cuenta de {accountHolder}");
    }

    public void Withdraw(string accountHolder, decimal amount)
    {
        Console.WriteLine($"Retiro de {amount:C} de la cuenta de {accountHolder}");
    }

    public void DisplayBalance(string accountHolder)
    {
        Console.WriteLine($"Saldo en la cuenta de {accountHolder}");
    }

}
