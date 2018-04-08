namespace RandomItemGenerator
{
    public abstract class BaseItem
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public string Type { get; private set; }
        public string Tier { get; private set; }
        public BaseItem(string name, string type, Tier tier)
        {
            Name = name;
            Value = GetValue(tier, type);
            Type = type;
            Tier = tier.Name;
        }
        int GetValue(Tier tier, string type)
        {
            int value = 0;
            //may use in the future
            // switch (tier.Name)
            // {
            //     case "Typical":
            //         value += 1;
            //         break;
            //     case "Stiff":
            //         value += 3;
            //         break;
            //     case "Great":
            //         value += 20;
            //         break;
            //     case "Legendary":
            //         value += 50;
            //         break;
            //     default:
            //         value += 0;
            //         break;
            // }
            switch (type)
            {
                case "Armor":
                    value += 10 * tier.Max;
                    break;
                case "Weapon":
                    value += 3 * tier.Max;
                    break;
                case "Potion":
                    value += 50 * tier.Max;
                    break;
                case "Scroll":
                    value += 75 * tier.Max;
                    break;
                default:
                    value += 0;
                    break;
            }
            return value;
        }
    }
}