using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone: Implementado!

Console.WriteLine("Smartphone Nokia: ");
Smartphone novoNokia = new Nokia(numero:"" ,modelo: "Modelo 1", imei: "111111111", memoria: 64);
novoNokia.Ligar();
Console.WriteLine("Digite o nome do aplicativo para instalar: ");
string nomeApp = Console.ReadLine();
novoNokia.InstalarAplicativo(nomeApp);

Console.WriteLine("\n");
Console.WriteLine("**********************************");
Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone novoIphone = new Iphone(numero: "", modelo: "Modelo 2", imei: "222222222", memoria: 128);
novoIphone.ReceberLigacao();
Console.WriteLine("Digite o nome do aplicativo para instalar: ");
nomeApp = Console.ReadLine();
novoIphone.InstalarAplicativo(nomeApp);

