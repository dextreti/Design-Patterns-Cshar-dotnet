// See https://aka.ms/new-console-template for more information
// Ricardo Huerta Dextre
using Builder;

//1. Abstract Builder: The Builder is an interface defining all the steps to make the concrete product.  
//2. Concrete Builder: The Concrete Builder Classes implements the Abstract Builder interface and provides implementation to all the abstract methods.
//   The Concrete Builder is responsible for constructing and assembling the individual parts of the product by implementing the Builder interface. 
//   It also defines and tracks the representation it creates. 
//3. Director: The Director takes those individual processes from the Builder and defines the sequence to build the product. 
//4. Product: The Product is a class, and we want to create this product object using the builder design pattern. 
//   This class defines different parts that will make the product. 

var Director = new DirectorBurger();
Director.Construct();
