using AbstractFactory;

namespace FactoryMethod;

public class PostgreConcreteCreator : ICreator
{
    public IDataCommand FactoryCommand()
    {
        return new PostgreConcrete();
    }

    public IDataConnection FactoryConnection()
    {
        return new PostgreConcrete();
    }
}
