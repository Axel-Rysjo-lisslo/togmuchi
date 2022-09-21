Console.WriteLine("wälkom till togmuchi");

togmuchi togmuchi = new togmuchi();

Console.WriteLine("välj ett bra namn");
togmuchi.namn = Console.ReadLine();



Console.WriteLine($"{togmuchi.namn} är väll okej det finns bättre.");




while ( togmuchi.Leva() == true)
{
    Console.Clear();
    togmuchi.stats();
    Console.WriteLine("Du måste mata den!");
    Console.WriteLine($"1. Matar {togmuchi.namn}");
    Console.WriteLine($"2. mata den inte {togmuchi.namn}");

string val = Console.ReadLine();
if (val == "1")
{
togmuchi.Mata();
}
else
{

Console.WriteLine("matar den inte");
}
togmuchi.tik();
}

Console.WriteLine($" bra du matade inte de nu är {togmuchi.namn} död");
Console.WriteLine("tryck enter för att göra en ny");
Console.ReadLine();