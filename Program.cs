using System;
using System.Threading;

namespace RandomItemGenerator
{
    class Program
    {
        static int armors;
        static int weapons;
        static int scrolls;
        static int potions;
        static int total;
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            // generator.Create();
            string[] _itemTypes = new string[] { "Armor", "Weapon", "Potion", "Scroll" };
            Random _Random = new Random();


            string ChooseType()
            {
                int percent = _Random.Next(1, 100);
                int index = 0;
                total++;
                if (percent < 50)
                {
                    armors++;
                }
                if (percent >= 50 && percent < 80)
                {
                    index = 1;
                    weapons++;
                }
                else if (percent >= 80 && percent < 96)
                {
                    index = 2;
                    potions++;
                }
                else if (percent >= 96 && percent <= 100)
                {
                    index = 3;
                    scrolls++;
                }
                System.Console.WriteLine($"armors:{armors} weapons:{weapons} potions:{potions} scrolls:{scrolls} total:{total}");
                return _itemTypes[index];
            }
            while (true)
            {
                Thread.Sleep(300);
                System.Console.WriteLine(ChooseType());
            }
        }
    }
}
