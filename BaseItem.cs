namespace RandomItemGenerator
{
    public abstract class BaseItem
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public string Type { get; private set; }
        public BaseItem(string name, int value, string type)
        {
            Name = name;
            Value = value;
            Type = type;
        }
    }
}