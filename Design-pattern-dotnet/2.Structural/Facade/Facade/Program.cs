// See https://aka.ms/new-console-template for more information


using Facade;

///The Facade Design Pattern is a structural pattern that provides a simplified interface to a complex system of classes, 
///libraries, or frameworks. The primary goal of the Facade pattern is to present a clear, simplified, 
///and minimized interface to the external clients while delegating all the complex underlying operations to the appropriate classes within the system


BankingFacade bankingSystem = new BankingFacade();

// Cliente utiliza la fachada para realizar operaciones bancarias
bankingSystem.OpenAccount("John Doe", 1000.0m);
bankingSystem.Deposit("John Doe", 500.0m);
bankingSystem.DisplayBalance("John Doe");

bankingSystem.RequestLoan("John Doe", 2000.0m);
bankingSystem.IssueCreditCard("John Doe");
bankingSystem.MakeCreditCardPurchase("John Doe", 300.0m);