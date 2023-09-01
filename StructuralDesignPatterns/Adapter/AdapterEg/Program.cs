// See https://aka.ms/new-console-template for more information
using AdapterEg;

Console.WriteLine("Hello, World!");
Adaptee adaptee = new Adaptee();
ITarget adapter = new Adapter(adaptee);
adapter.Request();
