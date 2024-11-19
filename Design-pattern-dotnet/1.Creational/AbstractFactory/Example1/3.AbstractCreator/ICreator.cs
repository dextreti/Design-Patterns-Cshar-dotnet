

using AbstractFactory;

namespace FactoryMethod;

public interface ICreator
{
    IDataCommand FactoryCommand();
    IDataConnection FactoryConnection();
}
