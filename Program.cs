﻿using DesafioPOO.Models;

// OK Realizando os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "55555", modelo: "Modelo 1", imei: "111111111", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "77777", modelo: "Modelo 2", imei: "222222222", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();