using SpelDomain;

namespace SpelApp;

class Program
{
    static void Main()
    {
        Character character;
        try
        {
            character = GameData.LoadCharacter();
        }
        catch
        {
            character = new();
        }
        Text text = new(character);

        text.Start();
        GameData.SaveCharacter(character);

        text.Tutorial();
        GameData.SaveCharacter(character);

        text.FirstQuest();
        GameData.SaveCharacter(character);

        text.FirstChoice();
        GameData.SaveCharacter(character);

        Console.WriteLine("Slut");

    }
}
