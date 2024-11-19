// See https://aka.ms/new-console-template for more information
/// Ricardo Huerta Dextre
using FactoryMethod;

// Product: This is the interface or abstract class defining the product the factory method will create.
// ConcreteProduct: These are the specific implementations of the Product interface or abstract class.
// Creator: This abstract class or interface declares the FactoryMethod().
// ConcreteCreator: Subclasses of Creator that implement the FactoryMethod() to produce ConcreteProduct instances.

// begin: una propuesta mejor de implementacion
Client productGeneric = new Client(new OracleConcreteCreator());
productGeneric.ExecuteQuery("Select * from product");
productGeneric = new Client(new PostgreConcreteCreator());
productGeneric.ExecuteQuery("Select * from fruit");
productGeneric = new Client(new PostgreConcreteCreator());
productGeneric.ExecuteQuery("Select * from client");