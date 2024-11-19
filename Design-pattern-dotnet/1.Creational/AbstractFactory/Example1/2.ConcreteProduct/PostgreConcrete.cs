using AbstractFactory;

namespace FactoryMethod;

public class PostgreConcrete : IDataConnection, IDataCommand
{
    public void Connect()
    {
        Console.WriteLine("Connected PostGre Database");
    }

    public void Execute(string query, IDataConnection connection)
    {
        connection.Connect();
        Console.WriteLine("Executing Oracle query: " + query);
    }
}
