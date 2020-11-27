using FinalObjectClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class PlayerCharacter : Creature
{
    public Races race;
    public string Name;
    public PlayerCharacter() : base()
    {
        int[]PlayerStats = mkStats();

        int[] dice = new int[4];

        this.Strength = PlayerStats[0];

        this.Dexterity = PlayerStats[1];

        this.Constitution = PlayerStats[2];

        this.Intelligence = PlayerStats[3];

        this.Wisdom = PlayerStats[4];

        this.Charisma = PlayerStats[5];

        this.HP = 10 + (this.Constitution - 10) / 2;

        this.ArmorClass = 10 + (this.Dexterity - 10) / 2;

    }


    public override string Attack(Creature defender)
    {
        return ""; // add in attacks
    }
    public static int[] Stats(int[] PlayerStats)
    {


        /* Randomly Generated stats */
        System.Random randNumGen = new Random();
        char rollOrKeep = 'r';
        string charLabel = "";
        string[] attributeLabels = new string[6] { "STR", "DEX", "CON", "INT", "WIS", "CHA" };
        int[] stats = { 0, 0, 0, 0, 0, 0 };
        while (rollOrKeep != 'k')
        {
            /* DICE ROLL * 4, sort, keep top 3 */
            for (int attr = 0; attr < stats.Length; attr++)
            {
                int[] dice = new int[4];
                for (int die = 0; die < dice.Length; die++)
                {
                    dice[die] = randNumGen.Next(0, 6) + 1;
                }
                System.Array.Sort(dice);
                stats[attr] = dice[1] + dice[2] + dice[3];
            }
            stats[0] = 0;
            stats[1] = 0;
            stats[2] = 0;
            stats[3] = 0;
            stats[4] = 0;
            stats[5] = 0;



            System.Console.WriteLine("Randomly Generated Scores: ");
            System.Console.WriteLine("  STR: " + "{0,2}", stats[0]);
            System.Console.WriteLine("  DEX: " + "{0,2}", stats[1]);
            System.Console.WriteLine("  CON: " + "{0,2}", stats[2]);
            System.Console.WriteLine("  INT: " + "{0,2}", stats[3]);
            System.Console.WriteLine("  WIS: " + "{0,2}", stats[4]);
            System.Console.WriteLine("  CHA: " + "{0,2}", stats[5]);
            System.Console.WriteLine();
            System.Console.Write("Do you want to (k)eep or (r)eroll? ");
            rollOrKeep = (System.Console.ReadLine()).ToCharArray()[0];
            System.Console.WriteLine("\n\n====================================");
        }

        /* RACE SELECTION */
        char raceSelect = '0';
        System.Console.WriteLine("  1 - Dragonborn");
        System.Console.WriteLine("  2 - Dwarf");
        System.Console.WriteLine("  3 - Elf");
        System.Console.WriteLine("  4 - Gnome");
        System.Console.WriteLine("  5 - Half-Elf");
        System.Console.WriteLine("  6 - Half-Orc");
        System.Console.WriteLine("  7 - Halfling");
        System.Console.WriteLine("  8 - Human");
        System.Console.WriteLine("  9 - Tiefling");
        System.Console.WriteLine();
        System.Console.Write("  Select a race: ");
        while (raceSelect < '1' || raceSelect > '9')
        {
            raceSelect = (System.Console.ReadLine()).ToCharArray()[0];

        }
        System.Console.WriteLine("\n\n====================================");

        char subraceSelect = '0';
        char statChoice = '0';
        char secondStatChoice = '0';
        /* SUBRACE SELECTION */

        if (raceSelect == '2')
        {
            System.Console.WriteLine("  1 - Hill Dwarf");
            System.Console.WriteLine("  2 - Mountain Dwarf");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '2')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '3')
        {
            System.Console.WriteLine("  1 - High Elf");
            System.Console.WriteLine("  2 - Wood Elf");
            System.Console.WriteLine("  3 - Dark Elf (Drow)");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '3')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }


        if (raceSelect == '4')
        {
            System.Console.WriteLine("  1 - Forest Gnome");
            System.Console.WriteLine("  2 - Rock Gnome");
            System.Console.WriteLine("  3 - Deep Gnome (Svirfneblin)");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '3')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '5')
        {

            System.Console.WriteLine("  1 - Strength (STR)");
            System.Console.WriteLine("  2 - Dexterity (DEX)");
            System.Console.WriteLine("  3 - Constitution (CON)");
            System.Console.WriteLine("  4 - Intelligence (INT)");
            System.Console.WriteLine("  5 - Wisdom (WIS)");
            System.Console.WriteLine();
            System.Console.Write("Select an attribute to increase: ");
            while (statChoice < '1' || statChoice > '5')
            {
                statChoice = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
            if (statChoice != '1')
            {
                System.Console.WriteLine("  1 - Strength (STR)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '2')
            {
                System.Console.WriteLine("  2 - Dexterity (DEX)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '3')
            {
                System.Console.WriteLine("  3 - Constitution (CON)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '4')
            {
                System.Console.WriteLine("  4 - Intelligence (INT)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '5')
            {
                System.Console.WriteLine("  5 - Wisdom (WIS)");
            }
            System.Console.WriteLine();
            System.Console.Write("Select a second attribute to increase: ");
            while (secondStatChoice < '1' || secondStatChoice > '5' || secondStatChoice == statChoice)
            {
                secondStatChoice = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '7')
        {
            System.Console.WriteLine("  1 - Lightfoot");
            System.Console.WriteLine("  2 - Stout");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '2')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '9')
        {
            System.Console.WriteLine("  1 - Dexterity (DEX)");
            System.Console.WriteLine("  2 - Charisma (CHA)");
            System.Console.WriteLine();
            System.Console.Write("Select an attribute to increase: ");
            while (statChoice < '1' || statChoice > '2')
            {
                statChoice = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        /* RACE ATTRIBUTE MODIFIERS */
        int[] racialModifiers = new int[6] { 0, 0, 0, 0, 0, 0 };
        if (raceSelect == '1')
        {
            charLabel = "Dragonborn";
            racialModifiers = new int[6] { 2, 0, 0, 0, 0, 1 };
        }
        else if (raceSelect == '2')
        {
            racialModifiers = new int[6] { 0, 0, 2, 0, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "Hill Dwarf";
                racialModifiers[4] += 1;
            }
            else
            {
                charLabel = "Mountain Dwarf";
                racialModifiers[0] += 2;
            }
        }
        else if (raceSelect == '3')
        {
            racialModifiers = new int[6] { 0, 2, 0, 0, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "High Elf";
                racialModifiers[3] += 1;
            }
            else if (subraceSelect == '2')
            {
                charLabel = "Wood Elf";
                racialModifiers[4] += 1;
            }
            else
            {
                charLabel = "Dark Elf (Drow)";
                racialModifiers[5] += 1;
            }
        }
        else if (raceSelect == '4')
        {
            racialModifiers = new int[6] { 0, 0, 0, 2, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "Forest Gnome";
                racialModifiers[1] += 1;
            }
            else if (subraceSelect == '2')
            {
                charLabel = "Rock Gnome";
                racialModifiers[2] += 1;
            }
            else
            {
                charLabel = "Deep Gnome (Svirfneblin)";
                racialModifiers[1] += 1;
            }
        }
        else if (raceSelect == '5')
        {
            charLabel = "Half-Elf";
            racialModifiers = new int[6] { 0, 0, 0, 0, 0, 2 };
            racialModifiers[statChoice - '1'] += 1;
            racialModifiers[secondStatChoice - '1'] += 1;
        }
        else if (raceSelect == '6')
        {
            charLabel = "Half-Orc";
            racialModifiers = new int[6] { 2, 0, 1, 0, 0, 0 };
        }
        else if (raceSelect == '7')
        {
            racialModifiers = new int[6] { 0, 2, 0, 0, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "Lightfoot Halfling";
                racialModifiers[5] += 1;
            }
            else
            {
                charLabel = "Stout Halfling";
                racialModifiers[2] += 1;
            }
        }
        else if (raceSelect == '8')
        {
            charLabel = "Human";
            racialModifiers = new int[6] { 1, 1, 1, 1, 1, 1 };
        }
        else if (raceSelect == '9')
        {
            racialModifiers = new int[6] { 0, 0, 0, 1, 0, 0 };
            if (statChoice == '1')
            {
                racialModifiers[1] += 2;
            }
            else
            {
                racialModifiers[5] += 2;
            }
        }

        /* PRINT CHARACTER SHEET */
        System.Console.WriteLine($"{charLabel}\n");
        for (int row = 0; row < stats.Length; row++)
        {

            stats[row] = (stats[row] + racialModifiers[row]);
            System.Console.WriteLine($"{attributeLabels[row]}: {(stats[row] + racialModifiers[row]),2} = {stats[row],2} + {racialModifiers[row],2}");

        }

        System.Console.WriteLine("\n====================================");
        return stats;
    }


    public override string DefendAgainst(Creature defender)
    {
        throw new NotImplementedException();
    }

   

    public void RacePick()
    {
        string[] attributeLabels = new string[6] { "STR", "DEX", "CON", "INT", "WIS", "CHA" };
        int[] attributes = new int[6];

        string charLabel="";
        /* RACE SELECTION */
        char raceSelect = '0';
        System.Console.WriteLine("  1 - Dragonborn");
        System.Console.WriteLine("  2 - Dwarf");
        System.Console.WriteLine("  3 - Elf");
        System.Console.WriteLine("  4 - Gnome");
        System.Console.WriteLine("  5 - Half-Elf");
        System.Console.WriteLine("  6 - Half-Orc");
        System.Console.WriteLine("  7 - Halfling");
        System.Console.WriteLine("  8 - Human");
        System.Console.WriteLine("  9 - Tiefling");
        System.Console.WriteLine();
        System.Console.Write("  Select a race: ");
        while (raceSelect < '1' || raceSelect > '9')
        {
            raceSelect = (System.Console.ReadLine()).ToCharArray()[0];

        }
        System.Console.WriteLine("\n\n====================================");

        char subraceSelect = '0';
        char statChoice = '0';
        char secondStatChoice = '0';
        /* SUBRACE SELECTION */

        if (raceSelect == '2')
        {
            System.Console.WriteLine("  1 - Hill Dwarf");
            System.Console.WriteLine("  2 - Mountain Dwarf");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '2')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '3')
        {
            System.Console.WriteLine("  1 - High Elf");
            System.Console.WriteLine("  2 - Wood Elf");
            System.Console.WriteLine("  3 - Dark Elf (Drow)");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '3')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }


        if (raceSelect == '4')
        {
            System.Console.WriteLine("  1 - Forest Gnome");
            System.Console.WriteLine("  2 - Rock Gnome");
            System.Console.WriteLine("  3 - Deep Gnome (Svirfneblin)");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '3')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '5')
        {

            System.Console.WriteLine("  1 - Strength (STR)");
            System.Console.WriteLine("  2 - Dexterity (DEX)");
            System.Console.WriteLine("  3 - Constitution (CON)");
            System.Console.WriteLine("  4 - Intelligence (INT)");
            System.Console.WriteLine("  5 - Wisdom (WIS)");
            System.Console.WriteLine();
            System.Console.Write("Select an attribute to increase: ");
            while (statChoice < '1' || statChoice > '5')
            {
                statChoice = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
            if (statChoice != '1')
            {
                System.Console.WriteLine("  1 - Strength (STR)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '2')
            {
                System.Console.WriteLine("  2 - Dexterity (DEX)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '3')
            {
                System.Console.WriteLine("  3 - Constitution (CON)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '4')
            {
                System.Console.WriteLine("  4 - Intelligence (INT)");
            }
            else
            {
                System.Console.WriteLine();
            }
            if (statChoice != '5')
            {
                System.Console.WriteLine("  5 - Wisdom (WIS)");
            }
            System.Console.WriteLine();
            System.Console.Write("Select a second attribute to increase: ");
            while (secondStatChoice < '1' || secondStatChoice > '5' || secondStatChoice == statChoice)
            {
                secondStatChoice = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '7')
        {
            System.Console.WriteLine("  1 - Lightfoot");
            System.Console.WriteLine("  2 - Stout");
            System.Console.WriteLine();
            System.Console.Write("Select a sub-race: ");
            while (subraceSelect < '1' || subraceSelect > '2')
            {
                subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        if (raceSelect == '9')
        {
            System.Console.WriteLine("  1 - Dexterity (DEX)");
            System.Console.WriteLine("  2 - Charisma (CHA)");
            System.Console.WriteLine();
            System.Console.Write("Select an attribute to increase: ");
            while (statChoice < '1' || statChoice > '2')
            {
                statChoice = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");
        }

        /* RACE ATTRIBUTE MODIFIERS */
        int[] racialModifiers = new int[6] { 0, 0, 0, 0, 0, 0 };
        if (raceSelect == '1')
        {
            charLabel = "Dragonborn";
            racialModifiers = new int[6] { 2, 0, 0, 0, 0, 1 };
            race = Races.Dragonborn;
;
        }
        else if (raceSelect == '2')
        {
            racialModifiers = new int[6] { 0, 0, 2, 0, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "Hill Dwarf";
                racialModifiers[4] += 1;
                race = Races.HillDwarf;
            }
            else
            {
                charLabel = "Mountain Dwarf";
                racialModifiers[0] += 2;
                race = Races.MountainDwarf;
            }
        }
        else if (raceSelect == '3')
        {
            racialModifiers = new int[6] { 0, 2, 0, 0, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "High Elf";
                racialModifiers[3] += 1;
                race = Races.HighElf;
            }
            else if (subraceSelect == '2')
            {
                charLabel = "Wood Elf";
                racialModifiers[4] += 1;
                race = Races.WoodElf;
            }
            else
            {
                charLabel = "Dark Elf (Drow)";
                racialModifiers[5] += 1;
                race = Races.DarkElf;
            }
        }
        else if (raceSelect == '4')
        {
            racialModifiers = new int[6] { 0, 0, 0, 2, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "Forest Gnome";
                racialModifiers[1] += 1;
                race = Races.ForestGnome;
            }
            else if (subraceSelect == '2')
            {
                charLabel = "Rock Gnome";
                racialModifiers[2] += 1;
                race = Races.RockGnome;
            }
            else
            {
                charLabel = "Deep Gnome (Svirfneblin)";
                racialModifiers[1] += 1;
                race = Races.DeepGnome;
            }
        }
        else if (raceSelect == '5')
        {
            charLabel = "Half-Elf";
            racialModifiers = new int[6] { 0, 0, 0, 0, 0, 2 };
            racialModifiers[statChoice - '1'] += 1;
            racialModifiers[secondStatChoice - '1'] += 1;
            race = Races.HalfElf;
        }
        else if (raceSelect == '6')
        {
            charLabel = "Half-Orc";
            racialModifiers = new int[6] { 2, 0, 1, 0, 0, 0 };
            race = Races.HalfOrc;
        }
        else if (raceSelect == '7')
        {
            racialModifiers = new int[6] { 0, 2, 0, 0, 0, 0 };
            if (subraceSelect == '1')
            {
                charLabel = "Lightfoot Halfling";
                racialModifiers[5] += 1;
                race = Races.LightFootHalfling;
            }
            else
            {
                charLabel = "Stout Halfling";
                racialModifiers[2] += 1;
                race = Races.StoutHalfling;
            }
        }
        else if (raceSelect == '8')
        {
            charLabel = "Human";
            racialModifiers = new int[6] { 1, 1, 1, 1, 1, 1 };
            race = Races.Human;
        }
        else if (raceSelect == '9')
        {
            racialModifiers = new int[6] { 0, 0, 0, 1, 0, 0 };
            race = Races.Tiefling;
            if (statChoice == '1')
            {
                racialModifiers[1] += 2;
            }
            else
            {
                racialModifiers[5] += 2;
            }

            /* PRINT CHARACTER SHEET */
            System.Console.WriteLine($"{charLabel}\n");
            for (int row = 0; row < attributes.Length; row++)
            {
                System.Console.WriteLine($"{attributeLabels[row]}: {(attributes[row] + racialModifiers[row]),2} = {attributes[row],2} + {racialModifiers[row],2}");
            }

            System.Console.WriteLine("\n====================================");
            this.Strength = attributes[0];
            this.Dexterity = attributes[1];
            this.Constitution = attributes[2];
            this.Intelligence = attributes[3];
            this.Wisdom = attributes[4];
            this.Charisma = attributes[5];
            
        }
        
    }
    public int [] mkStats()
    {
        int[] stats= new int[6];
        
        for(int count=0; count < stats.Length; count++)
        {

        }
            for (int count = 0; count < stats.Length; count++) {
            /* DICE ROLL * 4, sort, keep top 3 */
            stats[count] = Dice.Roll(4,6);
            }
        string rollOrKeep = "";
        int[] swap = new []{0, 1, 2, 3, 4, 5};
        while (!(rollOrKeep.Equals( "k")))
        {

            System.Console.WriteLine("Randomly Generated Scores: ");
            System.Console.WriteLine("1:  STR: " + "{0,2}", stats[swap[0]]);
            System.Console.WriteLine("2:  DEX: " + "{0,2}", stats[swap[1]]);
            System.Console.WriteLine("3:  CON: " + "{0,2}", stats[swap[2]]);
            System.Console.WriteLine("4:  INT: " + "{0,2}", stats[swap[3]]);
            System.Console.WriteLine("5:  WIS: " + "{0,2}", stats[swap[4]]);
            System.Console.WriteLine("6:  CHA: " + "{0,2}", stats[swap[5]]);
            System.Console.WriteLine();
            System.Console.Write("Do you want to (k)eep or (S)wap ");
            rollOrKeep = System.Console.ReadLine();
            
            System.Console.WriteLine("\n\n====================================");
            if (rollOrKeep.Equals("S")| rollOrKeep.Equals("s"))
            {
                Console.WriteLine("Enter 2 corisponding number for their rolls to be swaped");
                Console.WriteLine("Num 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine())-1;
                Console.WriteLine("Num 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine())-1;

                int temp = swap[num1];
                swap[num1] = swap[num2];
                swap[num2]=temp;
            }
        }
        Console.WriteLine("Enter a name");
        this.Name = Console.ReadLine();
        return stats;

    }


    public override string Use(IUsable used)
    {
        return "";
    }
}

/*public PlayerCharacter() : base()
    {
    int[] dice = new int[4];

    for (int die = 0; die < dice.Length; die++)
    {
        dice[die] = Dice.Roll(6);
    }
    this.Strength = dice.Sum() - dice.Min();

    for (int die = 0; die < dice.Length; die++)
    {
        dice[die] = Dice.Roll(6);
    }
    this.Dexterity = dice.Sum() - dice.Min();

    for (int die = 0; die < dice.Length; die++)
    {
        dice[die] = Dice.Roll(6);
    }
    this.Constitution = dice.Sum() - dice.Min();

    for (int die = 0; die < dice.Length; die++)
    {
        dice[die] = Dice.Roll(6);
    }
    this.Intelligence = dice.Sum() - dice.Min();

    for (int die = 0; die < dice.Length; die++)
    {
        dice[die] = Dice.Roll(6);
    }
    this.Wisdom = dice.Sum() - dice.Min();

    for (int die = 0; die < dice.Length; die++)
    {
        dice[die] = Dice.Roll(6);
    }
    this.Charisma = dice.Sum() - dice.Min();

    this.HP = 10 + (this.Constitution - 10) / 2;

    this.ArmorClass = 10 + (this.Dexterity - 10) / 2;

}*/
