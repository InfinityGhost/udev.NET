namespace udev.NET.Rules.Names
{
    /// <summary>
    /// Search the devpath upwards for a device with matching sysfs attribute values.
    /// </summary>
    public class ATTRS : AdvancedToken
    {
        public ATTRS(string key, Operator op, string value) : base(key, op, value)
        {
        }

        public override string Name => "ATTRS";
    }
}