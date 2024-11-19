using AbstractFactory;

namespace FactoryMethod;

public class SqlServerConcrete : IDataConnection, IDataCommand
{
    public void Connect()
    {
        Console.WriteLine("Connected Sqlserver Database");
    }

    public void Execute(string query, IDataConnection connection)
    {
        connection.Connect();
        Console.WriteLine("Executing Oracle query: " + query);
    }
}