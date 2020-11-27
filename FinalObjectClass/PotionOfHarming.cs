using System;
using System.Collections.Generic;
using System.Text;

namespace FinalObjectClass
{
    class PotionOfHarming:Potion
    {


        public PotionOfHarming() : base("Potion of Harming")
        {

        }

        public override bool used()
        {

            bool used = base.used();
            if (used)
            {
                this.recipient.HP -= 10;
                
            }

            return used;

        }



    }
}
