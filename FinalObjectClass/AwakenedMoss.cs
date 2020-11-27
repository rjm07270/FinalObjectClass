using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class AwakenedMoss : EarthTypes
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public AwakenedMoss() : base()
        {
            this.Strength = 12;
            this.Dexterity = 23;
            this.Constitution = 12;
            this.Intelligence = 19;
            this.Wisdom = 10;
            this.Charisma = 6;

            //HP 2d8+4
            this.HP = Dice.Roll(2, 8, 4);

            this.ArmorClass = 0;
        }

        /* Methods */


        public string wip(Creature def)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 6, 2);
                def.HP -= damage;
                return "Awakened Moss wips at " + def.GetType().Name +
                        " and hits for " + damage + " piercing damage!";
            }
            else
            {
                return "Awakened Moss wips at " + def.GetType().Name + " and misses!";
            }
        }


        public string photosynthesis(Creature def)
        {
            int toHeal = Dice.Roll(20, 4);
            if (toHeal > def.Dexterity || toHeal == 20)
            {
                int heal = Dice.Roll(1, 8);
                this.HP += heal;
                return "Awakened Moss uses photosynthesis and healed by " + heal;
            }
            else
            {
                return "Awakened Moss uses photosynthesis was in shade";
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  wip\n  wack";
        }

        public override string Attack(Creature c)
        {
            if (Dice.Roll(3) == 1)
            {
                return wip(c);
            }
            else if (Dice.Roll(2) == 2)
            {
                return photosynthesis(c);
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
