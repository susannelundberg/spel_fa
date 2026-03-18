using System.Text.Json;

namespace SpelDomain;

public class Character
{
    public string? Name { get; set; }
    public string? Weapon { get; set; }
    public int HealthPoints { get; set; }

    public void NameYourCharacter()
    {
        Console.WriteLine();
        Console.WriteLine("Välj ett namn till din karaktär:");
        Name = Console.ReadLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Hej {Name}");
        Console.ResetColor();
        Console.WriteLine();
    }

    public void ChooseYourWeapon()
    {
        Console.WriteLine("");
        Console.WriteLine("Välj ett vapen till din karaktär:");
        Console.WriteLine("Du kan välja mellan ett spjut(1), en pilbåge(2) eller en dolk(3)");
        string? choice = Console.ReadLine();
        Weapon = choice switch
        {
            "1" => "spjut",
            "2" => "pilbåge",
            "3" => "dolk",
            _ => "okänt vapen"
        };
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Du har valt {Weapon}");
        Console.ResetColor();
        Console.WriteLine();
    }

    
}
