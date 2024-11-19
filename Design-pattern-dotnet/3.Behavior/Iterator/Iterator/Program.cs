using Iterator;

///<pattern:Iterator>
/// is a behavioral design pattern that is commonly used in programming. 
/// Its main purpose is to provide a method to sequentially access the elements of a collection without exposing the internal representation of that collection.
///<Structure:>
///Iterator(Iterator): Defines an interface to access and traverse elements.
///Collection (Aggregate): Defines an interface to create an iterator.
///Concrete Iterator: Implements the iterator interface to access the elements of the collection.
///Concrete Collection (Concrete Aggregate): Implements the collection interface and returns an instance of a concrete iterator.

// Also "Task" allowing not expose Internal representation "Iterator"

Tasks tasks = new Tasks();
tasks.Add("Task 1");
tasks.Add("Task 2");
tasks.Add("Task 3");

IIterator<string> iterator = tasks.CreateIterator();

while (iterator.HasNext())
{
    string task = iterator.Next();
    Console.WriteLine("Task: " + task);
}