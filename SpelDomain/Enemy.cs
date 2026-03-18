namespace SpelDomain;

public class Enemy
{
    public string? Name { get; set; }
    public int HealthPoints { get; set; }
    public string? Weapon { get; set; }

    public void DiscoverEnemy(Character character, Enemy enemy)
    {
        Dice dice = new();
        Console.WriteLine();
        Console.WriteLine("Tryck på valfri tangent för att slå tärningen");
        dice.RollDice();
        Console.Clear();
        if (dice.Number > 3)
        {
            Console.WriteLine();
            Console.WriteLine(@"Du spanar noga längs flodens kant. 
Plötsligt ser du rörelsen i vattnet innan varelsen hinner anfalla.
Du är redo. Du får första attacken.");
            enemy.HealthPoints =-25;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine(@"Du böjer dig ner för att studera vattnet.
Plötsligt exploderar ytan framför dig!
Varelsen kastar sig mot dig innan du hinner reagera.
Fienden får första attacken.");
            character.HealthPoints =-25;
        }
    }
}
