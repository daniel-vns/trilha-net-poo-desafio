using DesafioPOO.Models;

Console.WriteLine($"\n");

Console.WriteLine($"--------------Smartphone Iphone--------------");
Iphone celular1 = new Iphone(numero: "81998242360", modelo: "13 PRO", imei: "3439g3v22", memoria: 128);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Facebook");

Console.WriteLine($"\n");

Console.WriteLine($"--------------Smartphone Nokia---------------");
Nokia celular2 = new Nokia(numero: "11995467890", modelo: "10+", imei: "124g43Rh335", memoria: 64);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Instagram");

Console.WriteLine($"\n");