using System;

namespace RandomItemGenerator
{
    public class Armor : StatItem
    {
        public float Defense { get; private set; }
        public string Slot { get; private set; }

        public Armor(string name, string slot, Random random, string type) : base(name, type, random, max)
        {

        }
    }
}