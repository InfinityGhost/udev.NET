namespace udev.NET.Rules
{
    public abstract class AdvancedToken : Token
    {
        protected AdvancedToken(string key, Operator op, string value) : base(key, op, value)
        {
        }

        public abstract string Name { get; }

        public override string ToString() => $"{Name}{{{Key}}}" + Operator.Format() + $"\"{Value}\"";
    }
}