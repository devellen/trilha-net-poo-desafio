using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("12345", "modelo 1", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("34565", "modelo 2", "123324", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("instagram");
