namespace RandomItemGenerator
{
    public class Armor : StatItem
    {
        public float Defense { get; private set; }
        public string Slot { get; private set; }

        public Armor(string name, int value, string type) : base(name, value, type)
        {

        }
    }
}