using SpelDomain;

namespace SpelApp;

class Program
{
    static void Main()
    {
        Character character = new();
        Enemy enemy = new();
        Dice dice = new();
        Text text = new(character, enemy);

        text.Start();

        text.Tutorial();

        text.FirstQuest();

        Console.WriteLine("Slut");

    }
}
