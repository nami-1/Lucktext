string name;
string age;
string sport;
string dricka;


Console.WriteLine("Hej! Vad heter du?");
name = Console.ReadLine();

Console.WriteLine($"Välkommen {name} ! ");

Console.WriteLine("Hur gammal är du?");
age = Console.ReadLine();

Console.WriteLine("Vad är din favorit sport?");
sport = Console.ReadLine();

Console.WriteLine("Skriv din favorit dricka!");
dricka = Console.ReadLine();


Console.WriteLine($"Hej du! {name} är {age} gammal, och har spelat mycket {sport} och nu behöver dricka {dricka}.");

Console.ReadLine();

