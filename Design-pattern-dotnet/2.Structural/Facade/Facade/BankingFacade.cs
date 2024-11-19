namespace Facade;

public class BankingFacade
{
    private AccountSubsystem bankAccountSubsystem;
    private LoanSubsystem loanSubsystem;
    private CreditCardSubsystem creditCardSubsystem;

    public BankingFacade()
    {
        bankAccountSubsystem = new AccountSubsystem();
        loanSubsystem = new LoanSubsystem();
        creditCardSubsystem = new CreditCardSubsystem();
    }

    // Método para crear una cuenta bancaria
    public void OpenAccount(string accountHolder, decimal initialBalance)
    {
        bankAccountSubsystem.Create(accountHolder, initialBalance);
    }

    // Método para realizar una transacción de depósito
    public void Deposit(string accountHolder, decimal amount)
    {
        bankAccountSubsystem.Deposit(accountHolder, amount);
    }

    // Método para realizar una transacción de retiro
    public void Withdraw(string accountHolder, decimal amount)
    {
        bankAccountSubsystem.Withdraw(accountHolder, amount);
    }

    // Método para mostrar el saldo de una cuenta
    public void DisplayBalance(string accountHolder)
    {
        bankAccountSubsystem.DisplayBalance(accountHolder);
    }

    // Método para solicitar un préstamo
    public bool RequestLoan(string accountHolder, decimal loanAmount)
    {
        return loanSubsystem.Approve(accountHolder, loanAmount);
    }

    // Método para emitir una tarjeta de crédito
    public void IssueCreditCard(string accountHolder)
    {
        creditCardSubsystem.IssueCreditCard(accountHolder);
    }

    // Método para realizar una compra con tarjeta de crédito
    public void MakeCreditCardPurchase(string accountHolder, decimal amount)
    {
        creditCardSubsystem.MakePurchase(accountHolder, amount);
    }

}
