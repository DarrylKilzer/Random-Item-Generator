using System;

namespace RandomItemGenerator
{
    public class Generator
    {
        string[] _Types = new string[] { "Armor", "Weapon", "Potion", "Scroll" };
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
            }
            return item;
        }
        string ChooseType()
        {
            int index = _Random.Next(0, _Types.Length);
            return _Types[index];
        }
        Armor CreateArmor()
        {
            string[] types = new string[] {"legs", "arms", "feet", "head", "chest"};
        }
        Weapon CreateWeapon()
        {

        }
        Potion CreatePotion()
        {

        }
    }
}