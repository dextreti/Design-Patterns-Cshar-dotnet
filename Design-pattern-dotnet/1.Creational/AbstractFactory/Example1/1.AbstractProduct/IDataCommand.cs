namespace AbstractFactory;

public interface IDataCommand
{
    void Execute(string query, IDataConnection connection);

}
