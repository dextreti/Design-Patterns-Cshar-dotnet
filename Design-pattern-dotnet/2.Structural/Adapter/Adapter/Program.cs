// See https://aka.ms/new-console-template for more information
using Adapter;

//dextre78@msn.com

///The Adapter Design Pattern is a structural pattern that allows objects with incompatible interfaces to work together. 
///It acts as a bridge between two incompatible interfaces. This pattern is useful when you want to use existing classes, 
///but their interfaces do not match the one you need.

//For this example we have simulated with two banks clients like: Interbank and Scotiabank
//The Consumer is who implement the adapters 

IBankApi<Trans> jsonAdapter = new JsonBankApiAdapter();
var result = jsonAdapter.GetTrans();
Console.WriteLine("Customer request transaction: From:{0}, To:{1}, Amount:{2}", result.From, result.To, result.Amount);
Trans trans = new() { From = "10101010", To = "202020", Amount = 1000 };
jsonAdapter.ExecTrans(trans);

IBankApi<Trans> xmlAdapter = new XmlBankApiAdapter();
result = xmlAdapter.GetTrans();
Console.WriteLine("Customer request transaction: From:{0}, To:{1}, Amount:{2}", result.From, result.To, result.Amount);
trans = new() { From = "5050505050", To = "80808080", Amount = 8000 };
xmlAdapter.ExecTrans(trans);


GenericApiAdapter generic = new GenericApiAdapter();
result = generic.GetTrans(jsonAdapter);
Console.WriteLine("Customer request transaction: From:{0}, To:{1}, Amount:{2}", result.From, result.To, result.Amount);
trans = new() { From = "77777777777", To = "6066060606", Amount = 9000 };
generic.ExecTrans(trans, jsonAdapter);

result = generic.GetTrans(xmlAdapter);
Console.WriteLine("Customer request transaction: From:{0}, To:{1}, Amount:{2}", result.From, result.To, result.Amount);
trans = new() { From = "4141414141414", To = "332323233323", Amount = 20000 };
generic.ExecTrans(trans, xmlAdapter);



