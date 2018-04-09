using System;

namespace RandomItemGenerator
{
    public abstract class StatItem : BaseItem
    {
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Constitution { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }
        public int HitPoints {get; private set;}
        public StatItem(string name, string type, Random random, Tier tier) : base(name, type, tier)
        {
            
            Strength = GenerateStat(tier, random, 1);
            Dexterity = GenerateStat(tier, random, 1);
            Constitution = GenerateStat(tier, random, 1);
            Intelligence = GenerateStat(tier, random, 1);
            Wisdom = GenerateStat(tier, random, 1);
            Charisma = GenerateStat(tier, random, 1);
            HitPoints = GenerateStat(tier, random, 3);
        }
        int GenerateStat(Tier tier, Random random, int multiplier)
        {
            int val = 0;
             switch (tier.Name)
            {
                case "Typical":
                    val = (random.Next(0,tier.Max)-2)*multiplier;
                    break;
                case "Stiff":
                    val = (random.Next(0,tier.Max)-2)*multiplier;
                    break;
                case "Great":
                    val = (random.Next(0,tier.Max)-2)*multiplier;
                    break;
                case "Legendary":
                    val = (random.Next(0,tier.Max)-2)*multiplier;
                    break;
            }
            if(val < 0)
            {
                val = 0;
            }
            return val; 
        }
    }
}