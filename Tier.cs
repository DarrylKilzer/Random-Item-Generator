namespace RandomItemGenerator
{
    public class Tier
    {
        public int Max { get; private set; }
        public string Name { get; private set; }
        public Tier(string name, int max)
        {
            Name = name;
            Max = max;
        }
    }
}