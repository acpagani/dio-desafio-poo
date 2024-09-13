using System.Transactions;
using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "119353534534", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone(numero: "1192342342", modelo: "16 pro max", imei: "22222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
