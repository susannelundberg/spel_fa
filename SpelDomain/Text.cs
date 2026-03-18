namespace SpelDomain;

public class Text
{
    private readonly Character? _character;
    public Text (Character character)
    {
        _character = character ?? throw new ArgumentNullException(nameof(character));
    }

    public void Start()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("-----------------------------------------------------------------------");
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
        Console.WriteLine();
        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
        Console.ReadKey();
        Console.Clear();

    }

    public void Tutorial()
    {   
        Enemy enemy = new(){Name = "giftspindel", Weapon = "giftiga käkar"};
        Console.WriteLine();
        Console.WriteLine(@$"Innan vi påbörjar äventyret så... 
Du står vid skogsbrynet, där en skugga rör sig snabbt bland träden. 
Plötsligt hoppar en förgiftad giftspindel fram och fräser hotfullt mot dig!
Det är dags att testa ditt valda vapen - visa vad du går för!
Du förbereder dig, håller ditt {_character!.Weapon} stadigt och gör dig redo att slå till.");
        Fight fight = new();
        fight.StartFight(_character, enemy);
        Console.WriteLine();
        Console.WriteLine("Nu har du provat på vad som kan hända i den magiska världen...");
        Console.WriteLine();
        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
        Console.ReadKey();
        Console.Clear();
    }

    public void FirstQuest()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(@$"När striden är över lägger sig tystnaden över skogsbrynet.
Du hör porlandet från floden som rinner strax intill byn. Vattnet ser mörkare ut än det borde… Något rör sig där under ytan.
En gammal legend säger att en magisk fisk vakar över floden. Den som lyckas fiska upp den sägs få naturens hjälp i kampen mot mörkret.");
        Fishing fish = new();
        fish.GoFish(_character!);
        Console.WriteLine();
        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
        Console.ReadKey();
        Console.Clear();

    }

    public void FirstChoice()
    {
        Enemy enemy = new();
        Dice dice = new();
        Fight fight = new();
        Console.Clear();
        Console.WriteLine(@$"Den magiska fisken glider sakta tillbaka ner i vattnet.
Innan den försvinner helt känner du en märklig värme sprida sig genom kroppen. En bild tonar fram i ditt sinne:
En by i nöd.
En stig som leder djupt in i skogen.
Du förstår att du måste välja hur du går vidare.");
        Console.WriteLine();
        Console.WriteLine("Om du väljer att gå mot byn, tryck 1. Om du väljer att gå in i skogen, tryck 2.");
        string? choice = Console.ReadLine();
        Console.Clear();
        switch (choice)
        {
            case "1":
            enemy.Name = "vattenalv";
            enemy.Weapon = "magiska strålar";
            Console.WriteLine();
            Console.WriteLine("Du vänder tillbaka mot byn. Om mörkret sprider sig här, kommer ingen vara säker.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"Du återvänder till byn med flodens mörka vatten fortfarande färskt i minnet.
Människorna här ser trötta och oroliga ut. Fisknäten hänger tomma, och ingen vågar längre dricka ur floden.
En äldre fiskare kliver fram.
“{_character!.Name}... Något lever där uppe i vattnet nu… något som inte hör hemma där.”");
            Console.WriteLine();
            Console.WriteLine("Ta reda på vad som förgiftar floden.");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"Du följer floden uppströms. Ju längre du går, desto mörkare blir vattnet.
Plötsligt ser du rörelser under ytan.");
            Console.WriteLine();
            enemy.DiscoverEnemy(_character!, enemy);
            Console.WriteLine();
            fight.StartFight(_character!, enemy);
            break;

            case "2":
            enemy.Name = "varelsen";
            enemy.Weapon = "giftiga klor";
            Console.WriteLine(@"Du följer den smala stigen som leder bort från floden och in i skogens djup.
Träden står tätare här, och luften känns märkligt tung.
Marken är fuktig, och du ser spår av något stort som rört sig mellan trädet.

Plötsligt hör du ett svagt porlande ljud längre fram.");
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(@"Du kliver fram mellan träden och ser en liten källa.
Vattnet borde vara klart, men istället är det mörkt och grömligt.
Runt källan ligger döda växter och vissen mossa.
            
Något har förgiftat vattnet här.");
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($@"När du böjer dig fram över vattnet bryts plötsligt ytan.
Ur källan kryper en grotest varelse upp ur det svarta vattnet.
Den ser ut som en blandning mellan en groda och en fisk, med glödande ögon och slemmig hud.

Den väser hotfullt {_character!.Name}... och blockerar vägen. Du bereder dig för strid!");
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            fight.BeginFight(_character!, enemy);
            _character!.HealthPoints =+ 100;
            Console.WriteLine($@"När varelsen faller tillbaka ner i vattnet börjar källan långsamt klarna.

Men innan vattnet blir helt rent ser du något blänka på botten.
En liten sten med ett svagt blått sken.

När du tar upp den känner du samma märkliga kraft som från den magiska fisken. Du har nu {_character.HealthPoints}");
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("FORTSÄTTNING FÖLJER.....");
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tangent för att fortsätta");
            Console.ReadKey();
            Console.Clear();
            break;

        }
    }
}