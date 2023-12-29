using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo A", imei: "10101", memoria: 120 );
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo B", imei: "01010", memoria: 210 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
