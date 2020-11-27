using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StoneMan : EarthTypes
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public StoneMan() : base()
        {
            this.Strength = 23;
            this.Dexterity = 4;
            this.Constitution = 20;
            this.Intelligence = 5;
            this.Wisdom = 5;
            this.Charisma = 15;

            //HP 2d8+4
            this.HP = Dice.Roll(2, 8, 4);

            this.ArmorClass = 17;
        }

        /* Methods */

        /* axe:
           Crushing Attack: +4 to hit, reach 5 ft., one target.
           Hit: (1d6 + 2) piercing damage.
        */
        public string landSlide(Creature def)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > def.Dexterity || toHit == 20)
            {
                int damage = Dice.Roll(1, 6, 2);
                def.HP -= damage;
                return "Stone Man uses land Slide " + def.GetType().Name +
                        " and does " + damage + " crushing damage!";
            }
            else
            {
                return "Stone Man uses land Slide " + def.GetType().Name + " and misses!";
            }
        }


        public string fortify(Creature def)
        {
            this.Constitution += 1;
            this.ArmorClass += 1;
            System.Console.WriteLine("fortify for one turn");
            System.Console.WriteLine(this.Attack(def));
            this.Resistances += "All";
            return "Stone Man fortify is over";
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  landSlide\n  fortify";
        }

        public override string Attack(Creature c)
        {
            if (Dice.Roll(3) == 1)
            {
                return landSlide(c);
            }
            else if (Dice.Roll(3) == 2)
            {
                return fortify(c);
            }
            else
            {
                return criple(c);
            }
        }

    public override string DefendAgainst(Creature attacker)
    {
        throw new NotImplementedException();
    }

    public override string Use(IUsable used)
    {
        throw new NotImplementedException();
    }
}
