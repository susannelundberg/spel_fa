namespace SpelDomain;

public class Text
{
    private readonly Character? _character;
    private  readonly Enemy? _enemy;
    public Text (Character character, Enemy enemy)
    {
        _character = character ?? throw new ArgumentNullException(nameof(character));
        _enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
    }

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Välkommen till Fiskarens arv!");
        Console.WriteLine(@"I en magisk värld hotas livet i floder, 
        sjöar och hav av en ond kraft som förgiftar vattnet och vägrar släppa taget om en uråldrig artefakt 
        — Fiskens Hjärtas Amulett. Din karaktär, en fiskare med ovanliga krafter och ett magiskt vapen, 
        måste ge sig ut på uppdrag för att hitta och rädda artefakten innan världen dränks i mörker.");

        Console.WriteLine();
        Console.ResetColor();
        _character!.NameYourCharacter();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Du ska nu välja ett vapen");
        Console.ResetColor();
        _character.ChooseYourWeapon();
    }

    public void Tutorial()
    {
        Console.WriteLine();
        Console.WriteLine(@$"Innan vi påbörjar äventyret så... 
        Du står vid skogsbrynet, där en skugga rör sig snabbt bland träden. 
        Plötsligt hoppar en förgiftad giftspindel fram och fräser hotfullt mot dig!
        Det är dags att testa ditt valda vapen - visa vad du går för!
        Du förbereder dig, håller ditt {_character!.Weapon} stadigt och gör dig redo att slå till.
        Tryck på valfri tangent för att kasta tärningen och se om du träffar fienden.");
        Dice dice = new();
        dice.RollDice();
        _character.HealthPoints = 100;
        _enemy!.HealthPoints = 100;

        while (_character.HealthPoints > 0 && _enemy.HealthPoints > 0){

            if (dice.Number > 3)
            {
                _enemy.HealthPoints -= 50;
                Console.WriteLine(@$"Din attack träffar giftspindeln och den skriker till av smärta!
                Den har nu {_enemy.HealthPoints} HP kvar.");
            }
            else if (dice.Number < 4)
            {
                _character.HealthPoints -= 50;
                Console.WriteLine(@$"Din attack missar, och giftspindeln rusar mot dig med sina giftiga käkar!
                Du har nu {_character.HealthPoints} kvar.");
            }

            if (_enemy.HealthPoints == 0)
            {
                Console.WriteLine("Du vann!");
            }
            else if (_character.HealthPoints == 0)
            {
                Console.WriteLine("Du förlorade...");
            }
            else
            {
                Console.WriteLine("Tryck på valfri tangent för att kasta tärningen och se om du träffar fienden.");
                dice.RollDice();
            }
        }
    }

    public void FirstQuest()
    {
        Dice dice = new();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(@$"När striden är över lägger sig tystnaden över skogsbrynet.
        Du hör porlandet från floden som rinner strax intill byn. Vattnet ser mörkare ut än det borde… men något rör sig där under ytan.
        En gammal legend säger att en magisk fisk vakar över floden. Den som lyckas fiska upp den sägs få naturens hjälp i kampen mot mörkret.
        Du greppar ditt fiskeredskap och gör dig redo
        Kasta tärningen för att se om du lyckas fiska upp den magiska fisken.");
        Console.ResetColor();
        int i = 1;
        while (i == 1)
        {
            dice.RollDice();
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
        Console.WriteLine($"Den magiska fisken ger dig 100 hp. Du har nu {_character.HealthPoints}");
    }

    public void FirstChoice()
    {
        Dice dice = new();
        Console.WriteLine(@$"Den magiska fisken glider sakta tillbaka ner i vattnet.
        Innan den försvinner helt känner du en märklig värme sprida sig genom kroppen. En bild tonar fram i ditt sinne:
        En by i nöd.
        En stig som leder djupt in i skogen.
        Du förstår att du måste välja hur du går vidare.");
        Console.WriteLine("Om du väljer att gå mot byn, tryck 1. Om du väljer att gå in i skogen, tryck 2.");
        switch (dice.Number)
        {
            case 1:
            Console.WriteLine("Du vänder tillbaka mot byn. Om mörkret sprider sig här, kommer ingen vara säker.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(@"Du återvänder till byn med flodens mörka vatten fortfarande färskt i minnet.
            Människorna här ser trötta och oroliga ut.Fisknäten hänger tomma, och ingen vågar längre dricka ur floden.
            En äldre fiskare kliver fram.
            “Något lever där uppe i vattnet nu… något som inte hör hemma där.”");
            Console.WriteLine();
            Console.WriteLine("Ta reda på vad som förgiftar floden.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(@"Du följer floden uppströms. Ju längre du går, desto mörkare blir vattnet.
            Plötsligt ser du rörelser under ytan.");
            Console.WriteLine("Tryck på valfri tangent för att slå tärningen");
            dice.RollDice();
            if(dice.Number > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Du ser fienden tydligt.");
                }
            else if (dice.Number < 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Fienden överraskar dig.");
                }
            break;

            case 2:
            Console.WriteLine("Du följer den smala stigen som leder bort från floden och in i skogens djup. Något väntar där.");
            break;

        }
    }
}