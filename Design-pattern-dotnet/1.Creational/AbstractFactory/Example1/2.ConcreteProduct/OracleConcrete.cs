using AbstractFactory;

namespace FactoryMethod;

public class OracleConcrete : IDataConnection, IDataCommand
{
    public void Connect()
    {
        Console.WriteLine("Connected Oracle Database");
    }

    public void Execute(string query, IDataConnection connection)
    {
        connection.Connect();
        Console.WriteLine("Executing Oracle query: " + query);
    }
}
