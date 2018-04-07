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
        public StatItem(string name, int value, string type, int max) : base(name, value, type)
        {
            int[] stats = GenerateStats(max);
            Strength = stats[0];
            Dexterity = stats[1];
            Constitution = stats[2];
            Intelligence = stats[3];
            Wisdom = stats[4];
            Charisma = stats[5];
            HitPoints = stats[6];
        }
        int[] GenerateStats(int max)
        {
            return new int[] {}; 
        }
    }
}