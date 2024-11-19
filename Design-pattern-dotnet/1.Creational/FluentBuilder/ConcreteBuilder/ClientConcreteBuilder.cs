
namespace FluentBuilder;

public interface IClientConcreteFluentBuilder
{
    IClientConcreteBuilderFirstName WithFirstName(string name);
}
public interface IClientConcreteBuilderFirstName
{
    Client WithLastName(string name);
}

public class ClientConcreteBuilder : IClientConcreteFluentBuilder, IClientConcreteBuilderFirstName
{
    Client _client;

    internal ClientConcreteBuilder()
    {
        _client = new();
    }

    public IClientConcreteBuilderFirstName WithFirstName(string name)
    {
        _client.FirstName = name;
        return this;
    }

    Client IClientConcreteBuilderFirstName.WithLastName(string name)
    {
        _client.LastName = name;
        return _client;
    }
}
