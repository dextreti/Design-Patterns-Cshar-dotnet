// See https://aka.ms/new-console-template for more information

using Prototype;


/// To simplify the above definition, we can say that the Prototype Design Pattern gives us a way to create new or cloned objects from 
/// the existing object of a class. That means it clones the existing object with its data into a new object. If we make any changes to 
/// the cloned object (i.e., new object), it does not affect the original object


/// Shallow Copy
Teacher teacherA = new();
teacherA.Name = "Ricardo";
Teacher teacherB = teacherA;
teacherB.Name = "Fernando";
Teacher teacherC = teacherA.Clone();
teacherC.Name = "Carlos";

Console.WriteLine("Teacher A: ");
Console.WriteLine("Name: " + teacherA.Name);
Console.WriteLine("Teacher B: ");
Console.WriteLine("Name: " + teacherB.Name);
Console.WriteLine("Teacher C: ");
Console.WriteLine("Name: " + teacherC.Name);


/// Deep Copy

Student studentA = new();
studentA.Name = "Ricardo";
studentA.contact = new() { Email = "Ricardo@a.com", Phone = "111111111" };
Student studentB = studentA;
studentB.Name = "Fernando";
studentB.contact = new() { Email = "Fernando@b.com", Phone = "222222222" };

Student studentC = studentA.Clone();
studentC.Name = "Carlos";
studentC.contact = new() { Email = "Carlos@c.com", Phone = "333333333" };

Console.WriteLine("Student A: ");
Console.WriteLine("Name: {0} \nContact \nPhone: {1} - Email: {2}", studentA.Name, studentA.contact.Phone, studentA.contact.Email);
Console.WriteLine("Student B: ");
Console.WriteLine("Name: {0} \nContact \nPhone: {1} - Email: {2}", studentB.Name, studentB.contact.Phone, studentB.contact.Email);
Console.WriteLine("Student C: ");
Console.WriteLine("Name: {0} \nContact \nPhone: {1} - Email: {2}", studentC.Name, studentC.contact.Phone, studentC.contact.Email);







