using System;

namespace RandomItemGenerator
{
    public class Generator
    {
        string[] _itemTypes = new string[] { "Armor", "Weapon", "Potion", "Scroll" };
        string[] _armorTypes = new string[] { "Legs", "Arms", "Feet", "Head", "Chest" };
        string[] _potionTypes = new string[] { "Green", "Orange", "Red", "Blue", "Purple", "Yellow", "Black" };
        string[] _weaponTypes = new string[] { "GreatAxe", "BroadSword", "LongSword", "Spear", "Club", "Dagger", "Stiletto" };
        string[] adjectives = new string[] { "Absurd", "Crazy", "Exotic", "Fanciful", "Grotesque", "Imaginative", "Implausible", "Incredible", "Insane", "Ludicrous", "Odd", "Outlandish", "Preposterous", "Ridiculous", "Singular", "Unbelievable", "Unreal", "Weird", "Artificial", "Capricious", "Chimerical", "Comical", "Eccentric", "Erratic", "Extravagant", "Extreme", "Far-fetched", "Fictional", "Foolish", "Foreign", "Freakish", "Hallucinatory", "Illusive", "Irrational", "Mad", "Misleading", "nonsensical", "Out of Sight", "Peculiar", "Phantasmagorical", "Quaint", "Queer", "Suppositious", "Unlikely", "Wacky", "Whimsical" };
        string[] endings = new string[] { "Impotence", "Condescending", "Illiteracy", "Garbage", "Impedment", "Destruction", "Improbablity", "Death", "Astoundment", };
        Random _Random = new Random();
        public BaseItem Create()
        {
            BaseItem item = null;
            string type = ChooseType();
            switch (type)
            {
                case "Armor":
                    return CreateArmor();
                case "Weapon":
                    return CreateWeapon();
                case "Potion":
                    return CreatePotion();
                case "Scroll":
                    return CreateScroll();
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
        Armor CreateArmor()
        {
            string armorSlot = _armorTypes[_Random.Next(0, _armorTypes.Length)];
            string adjective = adjectives[_Random.Next(0, adjectives.Length)];
            string ending = endings[_Random.Next(0, endings.Length)];
            string name = NameGenerator(armorSlot, adjective, ending);
            return new Armor(name, armorSlot, adjective, ending);
        }
        Weapon CreateWeapon()
        {

        }
        Potion CreatePotion()
        {

        }
        Potion CreateScroll()
        {

        }
        string NameGenerator(string itemName)
        {
            return $"{adjective} {itemName} {}"
        }
    }
}