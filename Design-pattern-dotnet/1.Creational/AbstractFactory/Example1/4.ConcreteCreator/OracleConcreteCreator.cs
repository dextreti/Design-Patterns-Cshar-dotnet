

using AbstractFactory;

namespace FactoryMethod;

public class OracleConcreteCreator : ICreator
{
    public IDataCommand FactoryCommand()
    {
        return new OracleConcrete();
    }

    public IDataConnection FactoryConnection()
    {
        return new OracleConcrete();
    }
}
