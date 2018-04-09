using System;
namespace RandomItemGenerator
{
    public class Scroll : BaseItem
    {
        public bool Damaged { get; private set; }
        public Scroll(string name, string slot, Random random, string type, Tier tier) : base(name, type, tier)
        {
            Damaged = GetDamaged(tier, random);
        }
        bool GetDamaged(Tier tier, Random random)
        {
            int percent = random.Next(0, 100);
            bool damaged = true;
            switch (tier.Name)
            {
                case "Typical":
                    if (percent > 25)
                    {
                        damaged = false;
                    }
                    break;
                case "Stiff":
                    if (percent > 10)
                    {
                        damaged = false;
                    }
                    break;
                case "Great":
                    if (percent > 5)
                    {
                        damaged = false;
                    }
                    break;
                case "Legendary":
                    if (percent > 0)
                    {
                        damaged = false;
                    }
                    break;
                default:
                    if (percent > 50)
                    {
                        damaged = false;
                    }
                    break;
            }
            return damaged;
        }
    }
}