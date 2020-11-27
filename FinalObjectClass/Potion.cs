using System;

abstract class Potion : Item
{

    public Creature recipient { get; set; }

    public Potion(String n) : base(n, 1)
    {

    }

}