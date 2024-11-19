using AbstractFactory;

namespace FactoryMethod;

public class SqlServerConcreteCreator : ICreator
{
    public IDataCommand FactoryCommand()
    {
        return new SqlServerConcrete();
    }

    public IDataConnection FactoryConnection()
    {
        return new SqlServerConcrete();
    }
}
