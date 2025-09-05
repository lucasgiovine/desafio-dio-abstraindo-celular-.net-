using DesafioPOO.Models;

Smartphone iphone = new Iphone("123", "xr", "123", 16);
Smartphone nokia = new Nokia("456", "3310", "456", 8);

Console.WriteLine("Testando Iphone:");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine("");

Console.WriteLine("Testando Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Twitter");