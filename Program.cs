using Attacker;
using Attacker.Strategies;

Console.WriteLine("Janob murabbiy Standart vaziyatni qaysi futbolchi amalga oshirishini istaysiz?");
Console.Write("Futbolchini ismini yozing:");

string Name = Console.ReadLine();

Futbolchi futbolchi = new(Name);

futbolchi.ZarbaBeradi();

futbolchi.SetStandart(new Penalti());

futbolchi.ZarbaBeradi();

futbolchi.SetStandart(new JarimaZarbasi());

futbolchi.ZarbaBeradi();

Console.ReadLine();