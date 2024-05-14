using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("9999999", "Nokia teste", "1111111", 1024);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("8888888", "Iphone 15", "23232323", 2048);
iphone.Ligar();
iphone.InstalarAplicativo("Telegran");