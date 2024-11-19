
using ObserverPattern;

///<Observer:Concept>
///  Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically
///<Structure:>
/// 1.-Observer.- defines an updating interface for objects that should be notified of changes in a subject.
/// 2.-ConcreteObserver.- maintains a reference to a ConcreteSubject object, stores state that should stay consistent with the subject's
///                    implements the Observer updating interface to keep its state consistent with the subject's
/// 3.-Subject.- knows its observers, any number of Observer objects may observe a subject, provides an interface for attaching and detaching Observer objects.
/// 4.-ConcreteSubject.- stores state of interest to ConcreteObserver sends a notification to its observers when its state changes


// it's just to understand the concept, example simple

var customer1 = new Customer("Ricardo", "ricardo@soap.com");
var customer2 = new Customer("Carlos", "carlos@nixo.com");
//IObservables<Customer> store = new Store<Customer>();
var storeCustomer = new Store<Customer>();
storeCustomer.Subscribe(customer1);
storeCustomer.Subscribe(customer2);
storeCustomer.NotifyStockProduct("Customer: has arrived in the store the product: New Laptop HP");

storeCustomer.UnSubscribe(customer2);
storeCustomer.NotifyStockProduct("Customer: has arrived in the store the product: New Laptop HP\n");

//((Store)store).NotifyProduct("New Laptop");
//((Store<Customer>)store).NotifyProduct("New Laptop");

var provider1 = new Provider("Josep", "josep@soms.com");
var provider2 = new Provider("Julia", "julia@netos.com");

// //IObservables<Provider> store = new Store<Customer>();
var storeProvider = new Store<Provider>();
storeProvider.Subscribe(provider1);
storeProvider.Subscribe(provider2);
storeProvider.NotifyStockProduct("Provider: We have not stock in the store the product: New Laptop HP");
storeProvider.UnSubscribe(provider2);
storeProvider.NotifyStockProduct("Provider: We have not stock in the store the product: New Laptop HP");