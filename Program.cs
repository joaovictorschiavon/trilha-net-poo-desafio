using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone nokia: ");
Smartphone nokia = new Nokia("1234", "Model 1", "imei 1", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Duoligo");

Console.WriteLine("Smartphone iphone: ");
Smartphone iphone = new Iphone("5678", "Model 2", "imei 2", 86);
iphone.Ligar();
iphone.InstalarAplicativo("ITunes");