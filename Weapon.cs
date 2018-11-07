using System;
using System.Collections.Generic;

namespace RandomItemGenerator
{
    public class Weapon : StatItem
    {
        public int Attack { get; private set; }
        public Weapon(string name, string slot, Random random, string type, Tier tier) : base(name, type, random, tier)
        {
            Attack = GetAttack(tier);
        }
        int GetAttack(Tier tier)
        {
            switch (tier.Name)
            {
                case "Typical":
                    return 10;
                case "Stiff":
                    return 15;
                case "Great":
                    return 25;
                case "Legendary":
                    return 50;
                default:
                    return 5;
            }
        }
    }
}