using System;

namespace RandomItemGenerator
{
    public class Generator
    {
        string[] _itemTier = new string[] { "Weak", "Typical", "Stiff", "Great", "Legendary" };
        string[] _itemTypes = new string[] { "Armor", "Weapon", "Potion", "Scroll" };
        string[] _armorTypes = new string[] { "Legs", "Arms", "Feet", "Head", "Chest" };
        string[] _potionTypes = new string[] { "Green", "Orange", "Red", "Blue", "Purple", "Yellow", "Black" };
        string[] _scrollTypes = new string[] { "Ancient", "Orange", "Red", "Blue", "Purple", "Yellow", "Black" };
        string[] _weaponTypes = new string[] { "GreatAxe", "BroadSword", "LongSword", "Spear", "Club", "Dagger", "Stiletto" };
        string[] adjectives = new string[] { "Absurd", "Crazy", "Exotic", "Fanciful", "Grotesque", "Imaginative", "Implausible", "Incredible", "Insane", "Ludicrous", "Odd", "Outlandish", "Preposterous", "Ridiculous", "Singular", "Unbelievable", "Unreal", "Weird", "Artificial", "Capricious", "Chimerical", "Comical", "Eccentric", "Erratic", "Extravagant", "Extreme", "Far-fetched", "Fictional", "Foolish", "Foreign", "Freakish", "Hallucinatory", "Illusive", "Irrational", "Mad", "Misleading", "nonsensical", "Out of Sight", "Peculiar", "Phantasmagorical", "Quaint", "Queer", "Suppositious", "Unlikely", "Wacky", "Whimsical" };
        string[] endings = new string[] { "Impotence", "Condescending", "Illiteracy", "Garbage", "Impedment", "Destruction", "Improbablity", "Death", "Astoundment", };
        Random _Random = new Random();
        public BaseItem Create()
        {
            BaseItem item = null;
            string type = ChooseType();
            Tier tier = ChooseTier();
            switch (type)
            {
                case "Armor":
                case "Weapon":
                case "Potion":
                case "Scroll":
                    item = CreateItem(tier, type);
                    break;
            }
            return item;
        }
        string ChooseType()
        {
            int percent = _Random.Next(1, 100);
            int index = 0;
            if (percent >= 50 && percent < 80)
            {
                index = 1;
            }
            else if (percent >= 80 && percent < 96)
            {
                index = 2;
            }
            else if (percent >= 96 && percent <= 100)
            {
                index = 3;
            }
            return _itemTypes[index];
        }
        Tier ChooseTier()
        {
            int percent = _Random.Next(1, 100);
            int index = 0;
            if (percent >= 50 && percent < 80)
            {
                index = 1;
            }
            else if (percent >= 80 && percent < 91)
            {
                index = 2;
            }
            else if (percent >= 91 && percent < 98)
            {
                index = 3;
            }
            else if (percent >= 98 && percent <= 100)
            {
                index = 4;
            }
            string tierName = _itemTier[index];
            switch (tierName)
            {
                case "Typical":
                    return new Tier(tierName, 1);
                case "Stiff":
                    return new Tier(tierName, 2);
                case "Great":
                    return new Tier(tierName, 3);
                case "Legendary":
                    return new Tier(tierName, 4);
                default:
                    return new Tier(tierName, 0);
            }
        }
        BaseItem CreateItem(Tier tier, string type)
        {
            string adjective = adjectives[_Random.Next(0, adjectives.Length)];
            string ending = endings[_Random.Next(0, endings.Length)];
            string name;
            switch (type)
            {
                case "Armor":
                    string armorSlot = _armorTypes[_Random.Next(0, _armorTypes.Length)];
                    name = NameGenerator(armorSlot, adjective, ending, tier, type);
                    return new Armor(name, armorSlot, _Random, type);
                case "Weapon":
                    string weaponType = _weaponTypes[_Random.Next(0, _weaponTypes.Length)];
                    name = NameGenerator(weaponType, adjective, ending, tier, type);
                    return new Weapon(name, weaponType, _Random, type);
                case "Potion":
                    string potionType = _potionTypes[_Random.Next(0, _potionTypes.Length)];
                    name = NameGenerator(potionType, adjective, ending, tier, type);
                    return new Potion(name, potionType, _Random, type);
                case "Scroll":
                    string scrollType = _scrollTypes[_Random.Next(0, _scrollTypes.Length)];
                    name = NameGenerator(scrollType, adjective, ending, tier, type);
                    return new Scroll(name, scrollType, _Random, type);
            }
            return null;

        }
        // Weapon CreateWeapon(Tier tier)
        // {
        //     return null;
        // }
        // Potion CreatePotion(Tier tier)
        // {
        //     return null;
        // }
        // Potion CreateScroll(Tier tier)
        // {
        //     return null;
        // }
        string NameGenerator(string itemName, string adjective, string ending, Tier tier, string type)
        {
            return $"{tier.Name} {type} {adjective} {itemName} of {ending}";
        }
    }
}