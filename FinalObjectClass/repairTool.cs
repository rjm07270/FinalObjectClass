using System;
using System.Collections.Generic;
using System.Text;


class repairTool: Item
{
    public Item recipient { get; set; }

    public repairTool() : base("Tool repair kit",10)
    {

    }
    public void repair()
    {
        this.recipient.charges=2;   
    }
    public override bool used()
    {


        if (charges > 0)
        {
            charges = charges - 1;
            return true;
        }
        else
        {
            return false;
        }
    
        
    }
}

