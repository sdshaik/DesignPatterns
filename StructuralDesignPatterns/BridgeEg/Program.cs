// See https://aka.ms/new-console-template for more information
using BridgeEg;

Console.WriteLine("Hello, World!");
IDevice tv = new Tv();
IDevice radio  = new Radio();

RemoteControl basicRemote = new BasicRemoteControl(tv);
RemoteControl advanceRemote = new AdvancedRemoteControl(radio);

basicRemote.TurnOn();
basicRemote.TurnOff();

advanceRemote.TurnOn();
advanceRemote.TurnOff();
