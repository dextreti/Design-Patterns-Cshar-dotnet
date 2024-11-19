// See https://aka.ms/new-console-template for more information



using Decorator;

/// <summary>
/// The Decorator Design Pattern in C# allows us to dynamically add new functionalities to an existing object without altering or modifying its structure, 
/// and this design pattern acts as a wrapper to the existing class. That means the Decorator Design Pattern dynamically changes the functionality 
/// of an object at runtime without impacting the existing functionality of the object. In short, this design pattern adds additional functionalities 
/// to the object by wrapping it. A decorator is an object that adds features to another object.
/// 
/// Component: The Component declares the common interfaces for both wrappers and wrapped objects.
/// Concrete Components: The Concrete Component is the class of objects that will be wrapped. It defines the original behaviour that can be altered by the decorators.
/// Base Decorator: The Base Decorator references the wrapped object. The base decorator delegates all operations to the wrapped object.
/// Concrete Decorators: The Concrete Decorator define additional behaviours that can be added to Concrete Components dynamically.
/// Client: The Client can wrap components in multiple layers of decorators, as long as it works with the objects via a shared interface.
/// </summary>

IPizza pizza = new Pizza();
pizza = new Onion(pizza);
pizza = new Pepperoni(pizza);
pizza = new Barbecue(pizza);
pizza.Prepare();

Console.WriteLine("*--------------------*");

pizza = new Barbecue(new Pepperoni(new Onion(new Pizza())));
pizza.Prepare();











