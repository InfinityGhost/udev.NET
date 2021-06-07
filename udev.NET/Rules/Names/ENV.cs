namespace udev.NET.Rules.Names
{
    /// <summary>
    /// Match against a device property value or set a device property value.
    /// </summary>
    public class ENV : AdvancedToken
    {
        public ENV(string key, Operator op, string value) : base(key, op, value)
        {
        }

        public override string Name => "ENV";
    }
}