using System;
using System.Security.Cryptography.X509Certificates;

class Program
    {
        static void Main(string[] args)
        {
        
        
        PlayerCharacter jack = new PlayerCharacter();

        
        Console.WriteLine(jack.HP);
        Potion thing = new PotionOfHealing();
        repairTool repair = new repairTool();
        thing.recipient = jack;
        jack.addToInventory(thing);
        jack.addToInventory(repair);
        use(thing,jack);
        }

    static void onevone(PlayerCharacter P1)
    {
        
    }
    
    static void use( Item thing=null, PlayerCharacter player=null)
    {
        Console.WriteLine("Pick A inventory slot");
        Console.WriteLine( player.showInventory());
        int input = Int32.Parse(Console.ReadLine());
        player.Use(thing);

    }
    }

