using System;

namespace RandomItemGenerator
{
    public class Armor : StatItem
    {
        public float Defense { get; private set; }
        public string Slot { get; private set; }

        public Armor(string name, string slot, Random random, string type, Tier tier) : base(name, type, random, tier)
        {
            Slot = slot;
            Defense = GetDefense(tier);
        }
        float GetDefense(Tier tier)
        {
            switch (tier.Name)
            {
                case "Typical":
                    return .10f;
                case "Stiff":
                    return .15f;
                case "Great":
                    return .25f;
                case "Legendary":
                    return .50f;
                default:
                    return .05f;
            }
        }
    }
}