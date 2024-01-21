// See https://aka.ms/new-console-template for more information
using ZealandClimateSystem;

Console.WriteLine("Hello, World!");



Lokale lokale = new Lokale("29", 40);
Lokale lokale1 = new Lokale("29", 21);
Lokale lokale2 = new Lokale("29", 31);


Målinger lokaleM = new Målinger(4, DateTime.Now, 20, 10, 25, lokale);
Console.WriteLine($"Her er målingens data og lokalets data: {lokaleM}");


MålingRegister register = new MålingRegister();

Console.WriteLine("------------------------------------------------------------");
Console.ReadKey();

Målinger lokaleM1 = new Målinger(1, DateTime.Now, 12, 10020, 143, lokale);
Målinger lokaleM2 = new Målinger(2, DateTime.Now, 17, 2523, 102, lokale1);
Målinger lokaleM3 = new Målinger(3, DateTime.Now, 25, 231, 100, lokale2);
Målinger lokaleM4 = new Målinger(4, DateTime.Now, 23, 231, 100, lokale2);
Målinger lokaleM5 = new Målinger(5, DateTime.Now, 22, 2913, 100, lokale2);


register.Add(lokaleM1);
register.Add(lokaleM2);
register.Add(lokaleM3);
register.Add(lokaleM4);
register.Add(lokaleM5);

List<Målinger> målinger = register.GetAll();

foreach (var item in målinger)
{
    Console.WriteLine($"Item: {item}");
}
Console.WriteLine("------------------------------------------------------------");
Console.ReadKey();
Console.WriteLine("Så kan vi kalde på en måling fra listen ved denne metode");

Console.WriteLine(register.GetMåling(3));
Console.WriteLine($"Antallet af ulovlige registreringer ad Co2: {register.AntalUlovlige}");

Console.WriteLine("------------------------------------------------------------");
Console.ReadKey();

List<Målinger> tempinteval = register.AlleTempUnderOver(20, 30);

foreach (var item in tempinteval)
{
    Console.WriteLine(item);
}

