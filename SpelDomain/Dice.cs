using System.Globalization;

namespace SpelDomain;

public class Dice
{
    public int Number { get; set; }
    public Dice()
    {
        Number = 0;
    }

    public void RollDice ()
    {
        Console.WriteLine("För att kasta tärningen, tryck på valfri tangent");
        Console.ReadKey();
        Random random = new();
        Number = random.Next(1, 7);
        Console.WriteLine();
        Console.WriteLine($"Du fick en {Number}a");
    }
 }
