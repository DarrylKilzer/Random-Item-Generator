namespace RandomItemGenerator
{
    public abstract class BaseItem
    {
        public string Name { get; private set; }
        public string Value { get; private set; }
        public string Type { get; private set; }
    }
}