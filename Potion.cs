using System;
namespace RandomItemGenerator
{
    public class Potion : StatItem
    {
        public bool Poisoned { get; private set; }
        public Potion(string name, string slot, Random random, string type, Tier tier) : base(name, type, random, tier)
        {
            Poisoned = GetPoisoned(tier, random);
        }
        bool GetPoisoned(Tier tier, Random random)
        {
            int percent = random.Next(0, 100);
            bool poisoned = true;
            switch (tier.Name)
            {
                case "Typical":
                    if (percent > 25)
                    {
                        poisoned = false;
                    }
                    break;
                case "Stiff":
                    if (percent > 10)
                    {
                        poisoned = false;
                    }
                    break;
                case "Great":
                    if (percent > 5)
                    {
                        poisoned = false;
                    }
                    break;
                case "Legendary":
                    if (percent > 0)
                    {
                        poisoned = false;
                    }
                    break;
                default:
                    if (percent > 50)
                    {
                        poisoned = false;
                    }
                    break;
            }
            return poisoned;
        }
    }
}