

namespace ObserverPattern;

public class Provider : IObserver<Provider>
{
    private string Name;
    private string Email;

    public Provider(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void Update(string message)
    {
        Console.WriteLine($"Sending email to {Name} at {Email}: {message}");
    }
}
