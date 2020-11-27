using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    abstract class Creature : IMobile, IActionable
    {
        /* Fields */

        private int[] attributes;
        public int X { get; set; }
        public int Y { get; set; }
        public int speed { get; set; }
        public  Direction Facing { get; set; }

        public int Initiative { get; set; }
        public  Item[] inventory { get; set; }



        
    /* Properties */

    public int HP { get; set; }
        public int ArmorClass { get; protected set; }
        public bool Darkvision { get; protected set; }
        public string Resistances { get; protected set; }
        public int Strength
        {
            get
            {
                return attributes[0];
            }

            protected set
            {
                attributes[0] = value;
            }
        }

        public int Dexterity
        {
            get
            {
                return attributes[1];
            }

            protected set
            {
                attributes[1] = value;
            }
        }

        public int Constitution
        {
            get
            {
                return attributes[2];
            }

            protected set
            {
                attributes[2] = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return attributes[3];
            }

            protected set
            {
                attributes[3] = value;
            }
        }

        public int Wisdom
        {
            get
            {
                return attributes[4];
            }

            protected set
            {
                attributes[4] = value;
            }
        }

        public int Charisma
        {
            get
            {
                return attributes[5];
            }

            protected set
            {
                attributes[5] = value;
            }
        }

        /* Constructors */

        public Creature()
        {
        this.X = Dice.Roll(4,6);
        this.Y = Dice.Roll(4, 6);
        this.attributes = new int[6];
        this.Darkvision = false;
        this.HP = 0;
        this.Resistances = "";
        this.Facing = Direction.NORTH;
        this.inventory = new Item[10];
    }

        /* methods */
        public void MoveNorth()
        {
            this.Y = this.Y - this.speed;
        }

        public void MoveWest()
        {
            this.X = this.X - this.speed;
        }

        public void MoveEast()
        {
            this.X = this.X + this.speed;
        }

        public void MoveSouth()
        {
            this.Y = this.Y + this.speed;
        }

        public void TurnLeft()
        {
            this.Facing = this.Facing - 45;
        }

        public void TurnRight()
        {
            this.Facing = this.Facing + 45;
        }

        public void Turn(int degrees)
        {
            this.Facing = this.Facing + degrees;
        }

        public void GoTo(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Face(Direction dir)
        {
        if (dir == Direction.NORTH)
        {
            this.Facing = Direction.NORTH;
        }
        else if (dir == Direction.NORTHEAST)
        {
            this.Facing = Direction.NORTHEAST;
        }
        else if (dir == Direction.EAST)
        {
            this.Facing = Direction.EAST;
        }
        else if (dir == Direction.SOUTHEAST)
        {
            this.Facing = Direction.SOUTHEAST;
        }
        else if (dir == Direction.SOUTH)
        {
            this.Facing = Direction.SOUTH;
        }
        else if (dir == Direction.SOUTHWEST)
        {
            this.Facing = Direction.SOUTHWEST;
        }
        else if (dir == Direction.WEST)
        {
            this.Facing = Direction.WEST;
        }
        else if (dir == Direction.NORTHWEST)
        {
            this.Facing = Direction.NORTHWEST;
        }
        }
    public static double ConvertDegreesToRadians(double degrees)
    {
        double radians = (Math.PI / 180) * degrees;
        return (radians);
    }
    public void MoveForward()
    {
        int length= Dice.Roll(1,6);

        this.X += Convert.ToInt32(length * Math.Cos(ConvertDegreesToRadians(90 - Convert.ToDouble(this.Facing))));
        this.Y += Convert.ToInt32(length * Math.Cos(ConvertDegreesToRadians(90 - Convert.ToDouble(this.Facing))));
    }
    public bool addToInventory(Item i)
    {
        
        for (int index = 0; index < inventory.Length; index++)
        {
            //check for empty slot
            if (inventory[index] == null)
            {
                inventory[index] = i;
                return true;
            }
        }
        //didn't find an empty slot :(
        return false;
    }

    public Item removeFromInventory(int slot)
    {

        Item retrieved = inventory[slot - 1];
        inventory[slot - 1] = null;
        return retrieved;
    }

    public string showInventory()
    {
        string output =
          "\n========================\n" +
          "        Inventory" +
          "\n========================\n";
        for (int index = 0; index < inventory.Length; index++)
        {
            if (inventory[index] == null)
            {
                output = output + (index + 1) + ": ... \n";
            }
            else
            {
                output = output + (index + 1) + ": " + inventory[index].Name + "\n";
            }

        }
        output = output + "========================\n";
        return output;

    }


    /* It is necessary to override ToString() from the object class
       if we want a custom serialized Creature object as a string.
    */
    public override string ToString()
        {
            string output =
                this.GetType().Name +
                "\n============" +
                "\nSTR: " + this.Strength +
                "\nDEX: " + this.Dexterity +
                "\nCON: " + this.Constitution +
                "\nINT: " + this.Intelligence +
                "\nWIS: " + this.Wisdom +
                "\nCHA: " + this.Charisma +
                "\n============" +
                "\nHP: " + this.HP +
                "\nAC: " + this.ArmorClass +
                "\nResistances: " + this.Resistances +
                "\n============" +
                "\nDarkvision: " + this.Darkvision + "\n"+
                "\n========================\n" +
                "        Inventory" +
                "\n========================\n";
                for (int index = 0; index < inventory.Length; index++)
                {
                    if (inventory[index] == null)
                    {
                    output = output + (index + 1) + ": ... \n";
                    }
                else
                    {
                    output = output + (index + 1) + ": " + inventory[index].Name + "\n";
                    }

                }
        output = output + "========================\n";
        return output;
            
        }


    /* We are required to implement Attack because we implement the
   IActionable interface. However, because Creature is abstract
   and there is no default attack, we will make Attack abstract
   and define specific Attacks in subclasses by overriding. 
*/
    public abstract string Attack(Creature defender);
    public string Defend()
    {
        this.Constitution += 10;
        return "Constitution has gone up by 10";
    }
    public abstract string DefendAgainst(Creature attacker);
    public abstract string Use(IUsable used);
    public string Rest()
    {
        this.HP += 10;
        return "HP increesed by 10";
    }
    
}



