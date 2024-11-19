// See https://aka.ms/new-console-template for more information


///In simple words, we can say that the Abstract Factory is a super factory that creates other factories. 
///This Abstract Factory is also called the Factory of Factories. 
///That means the Abstract Factory design pattern provides an interface for creating families of related or dependent products but leaves the actual 
///object creation to the concrete factory classes.


// AbstractFactory: Declares an interface for operations that create abstract products.This will be an interface for operations that will create Abstract Product objects.
// ConcreteFactory: Implements the operations to create concrete product objects.These classes implement the Abstract Factory interface and provide implementations for the interface methods. We can use these concrete classes to create concrete product objects.
// AbstractProduct: Declares an interface for a type of product object.These are going to be interfaces for creating abstract products.Here, we need to define the Operations a Product should have.
// ConcreteProduct: Implements the AbstractProduct interface. These are the classes that implement the Abstract Product interface.
// Client: Uses interfaces declared by AbstractFactory and AbstractProduct classes. This class will use our Abstract Factory and Abstract Product interfaces to create a family of products.


// 5.Client
using AbstractFactory;

IVehicleFactory vehicleFactory = new RegularVehicleFactory();
IBike bike = vehicleFactory.CreateBike();
bike.DisplayInfo();

vehicleFactory = new RegularVehicleFactory();
ICar car = vehicleFactory.CreateCar();
car.DisplayInfo();

vehicleFactory = new SportsVehicleFactory();
IBike bikeSport = vehicleFactory.CreateBike();
bikeSport.DisplayInfo();

vehicleFactory = new SportsVehicleFactory();
ICar carsport = vehicleFactory.CreateCar();
carsport.DisplayInfo();





