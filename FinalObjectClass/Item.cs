using System;

abstract class Item 
{

    public string Name { get; set; }
    public int charges { get; set; }
    public virtual bool used()
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

    public Item(string n, int initc)
    {
        this.Name = n;
        this.charges = initc;
    }

    public string name { get; set; }
    public Item(string n)
    {
        name = n;
    }

    public override string ToString()
    {
        return name;
    }
}