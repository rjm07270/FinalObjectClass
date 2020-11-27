using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    abstract class EarthTypes : Creature
    {
        /* Fields */
        /* Properties */
        /* Constructors */

        public EarthTypes() : base()
        {
            this.Darkvision = true;
            this.Resistances += "Cold ";
        }
        /* Methods */
        public string criple(Creature def)
        {
            //def.MkCrip();
            return this.GetType().Name + " wips at " + def.GetType().Name +
                  " is cripled ";
        }
    }
