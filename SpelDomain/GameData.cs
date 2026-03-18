using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.IO;

namespace SpelDomain;

public static class GameData
{
    public static void SaveCharacter(Character character, string filename = "Data/character.json")
    {
        string json = JsonSerializer.Serialize(character, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
    }

    public static Character LoadCharacter(string filename = "Data/character.json")
    {
        if (!File.Exists(filename))
            throw new FileNotFoundException("Ingen sparad karaktär hittades.");

        string json = File.ReadAllText(filename);
        return JsonSerializer.Deserialize<Character>(json)!; //Hur funkar denna?
    }
}
