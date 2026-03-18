namespace SpelDomain;

public class Fishing
{
    public void GoFish(Character _character)
    {
        Dice dice = new();
        Console.WriteLine(@$"Du greppar ditt {_character.Weapon} och gör dig redo
Kasta tärningen för att se om du lyckas fiska upp den magiska fisken.");
        Console.ResetColor();
        int i = 1;
        while (i == 1)
        {
            dice.RollDice();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (dice.Number == 5 || dice.Number == 6)
            {
                i = 0;
                Console.WriteLine("Lyckat fiske!");
            }
            else if (dice.Number == 3 || dice.Number == 4)
            {
                Console.WriteLine("Fisken nappar... nästan. Den bitar av betet och simmar iväg. Försök igen!");
            }
            else if (dice.Number == 1 || dice.Number == 2)
            {
                Console.WriteLine("Ingen napp! Försök igen");
            }
            Console.ResetColor();
        }
        _character!.HealthPoints += 100;
        Console.WriteLine($"Den magiska fisken ger dig 100 hp. Du har nu {_character.HealthPoints} hp.");
    }
}
