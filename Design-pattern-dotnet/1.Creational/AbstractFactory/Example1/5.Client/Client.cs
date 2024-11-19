using AbstractFactory;

namespace FactoryMethod;

public class Client
{

    private readonly IDataConnection _connection;
    private readonly IDataCommand _command;

    /// <summary>
    /// Correct! una mejor propuesta de implementar sin rompler el princio open close 
    /// </summary>
    /// <param name="factory"></param>
    public Client(ICreator factory)
    {
        _connection = factory.FactoryConnection();
        _command = factory.FactoryCommand();
    }

    public void ExecuteQuery(string query)
    {
        _command.Execute(query, _connection);
    }

}

