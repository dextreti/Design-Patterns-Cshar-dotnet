namespace ObserverPattern;

public class Customer : IObserver<Customer>
{
    private string Name;
    private string Email;
    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void Update(string message)
    {
        Console.WriteLine($"Sending email to {Name} at {Email}: {message}");
    }

}
