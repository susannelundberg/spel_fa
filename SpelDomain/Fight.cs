namespace SpelDomain;

public class Fight
{
    public void StartFight(Character _character, Enemy _enemy)
    {
        _character.HealthPoints = 100;          //Se över hantering av healthpoints
        _enemy!.HealthPoints = 100;

        while (_character.HealthPoints > 0 && _enemy.HealthPoints > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att kasta tärningen och se om du träffar fienden.");
            Dice dice = new();
            dice.RollDice();
            Console.Clear();

            if (dice.Number > 2)
            {
                _enemy.HealthPoints -= 25;
                Console.WriteLine(@$"Din attack träffar {_enemy.Name} som skriker till av smärta!
Den har nu {_enemy.HealthPoints} HP kvar.");
            }
            else
            {
                _character.HealthPoints -= 25;
                Console.WriteLine(@$"Din attack missar, och {_enemy.Name} rusar mot dig med sin {_enemy.Weapon}!
Du har nu {_character.HealthPoints} HP kvar.");
            }

            if (_enemy.HealthPoints <= 0)
            {
                Console.WriteLine("Du vann!");
            }
            else if (_character.HealthPoints == 0)
            {
                Console.WriteLine("Du förlorade...");
            }
        }
    }

    public void BeginFight(Character character, Enemy enemy)
    {
        Dice dice = new();
        enemy!.HealthPoints = 100;
        while (enemy.HealthPoints > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att kasta tärningen och se om du träffar fienden.");
            dice.RollDice();
            Console.Clear();

            if (dice.Number > 2)
            {
                enemy.HealthPoints -= 20;
                Console.WriteLine(@$"Din attack träffar {enemy.Name} som skriker till av smärta!
Den har nu {enemy.HealthPoints} HP kvar.");
            }
            else
            {
                Console.WriteLine(@$"Din attack missar, och {enemy.Name} rusar mot dig med sin {enemy.Weapon}!");
            }
        }

        Console.WriteLine($"Du besegrande {enemy.Name}");
    }
}
