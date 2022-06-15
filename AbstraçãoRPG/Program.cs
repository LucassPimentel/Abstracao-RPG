using AbstraçãoRPG.src.Entities;

var demogorgon = new Humanoid("Demogorgon", 10, "Humanoide", 1000);
Console.WriteLine(demogorgon.ToString());
Console.WriteLine(demogorgon.Attack(50));
Console.WriteLine("====================");
var SpiderMonster = new Beast("SpiderMonster", 12, "Besta", 1200);
Console.WriteLine(SpiderMonster.ToString());
Console.WriteLine(SpiderMonster.Attack(150, demogorgon));
Console.WriteLine("====================");
var Vecna = new Humanoid("Vecna", 99, "Humanoide", 2000);
Console.WriteLine(Vecna.ToString());
Console.WriteLine(Vecna.Attack(200, SpiderMonster));