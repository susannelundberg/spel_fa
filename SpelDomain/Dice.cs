using System.Globalization;

namespace SpelDomain;

public class Dice                   // Se över denna 
{
    public int Number { get; set; }
    public Dice()
    {
        Number = 0;
    }

    public void RollDice ()
    {
        Console.ReadKey();
        Random random = new();
        Number = random.Next(1, 7);
        Console.WriteLine();
    }
 }
