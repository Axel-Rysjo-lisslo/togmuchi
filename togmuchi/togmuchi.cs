using System;
using System.Collections.Generic;

public class togmuchi
{
    
    private int hunger;
    private List<string> ord = new List<string>() {"jak är hungrig"};
    private bool Lever;
    private Random generator;
    public string namn;

    public togmuchi()
    { 
        generator = new Random();
        Lever = true;   
    }

public void Mata() 
{
Console.WriteLine($"[{namn}] jag är inte mät än. MER!");
hunger -=1;
if(hunger < 0)
{

hunger = 0;

}
}
public void tik()
{

hunger++;
if (hunger > 5)
{

Lever = false;

}
public void stats()
{

Console.WriteLine($"name:{namn} || hunger: {hunger}");


}


}









}
