using System;

class PotionOfHealing : Potion
{

    public PotionOfHealing() : base("Potion of Healing")
    {
        
    }

    public override bool used()
    {

        bool used = true;
        if (used)
        {
            this.recipient.HP += 10;
            

        }

        return used;

    }



}