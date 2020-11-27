using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    class AwakenedTree : EarthTypes
    {
        /* Fields */
        /* Properties */
        /* Constructors */
        public AwakenedTree() : base()
        {
            this.Strength = 23;
            this.Dexterity = 8;
            this.Constitution = 17;
            this.Intelligence = 10;
            this.Wisdom = 10;
            this.Charisma = 5;

            //HP 2d8+4
            this.HP = Dice.Roll(2, 8, 4);

            this.ArmorClass = 0;
        }

        /* Methods */

        /* axe:
           Melee Weapon Attack: +4 to hit, reach 5 ft., one target.
           Hit: (1d6 + 2) piercing damage.
        */
        public string axe(Creature def)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 6, 2);
                def.HP -= damage;
                return "Awakened Tree throws his axe at " + def.GetType().Name +
                        " and hits for " + damage + " piercing damage!";
            }
            else
            {
                return "Awakened Tree throws his axe at " + def.GetType().Name + " and misses!";
            }
        }


        public string wack(Creature def)
        {
            int toHit = Dice.Roll(20, 4);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 8);
                def.HP -= damage;
                return "Awakened Tree swings his wack at " + def.GetType().Name +
                        " and hits for " + damage + " slap damage!";
            }
            else
            {
                return "Awakened tree swings his wack at " + def.GetType().Name + " and misses!";
            }
        }


        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  axe\n  wack";
        }

        public override string Attack(Creature c)
        {
            if (Dice.Roll(3) == 1)
            {
                return axe(c);
            }
            else if (Dice.Roll(3) == 2)
            {
                return wack(c);
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
}
