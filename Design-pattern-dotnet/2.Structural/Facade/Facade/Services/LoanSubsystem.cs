namespace Facade;

public class LoanSubsystem
{
    public bool Approve(string accountHolder, decimal loanAmount)
    {
        Console.WriteLine($"Aprobando préstamo para {accountHolder} por {loanAmount:C}");
        return true; // En un escenario real, la aprobación dependería de diversos factores
    }

}
