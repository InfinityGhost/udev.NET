namespace udev.NET.Rules.Names
{
    /// <summary>
    /// Match against a system-wide constant, depending on <see cref="Token.Key"/>.
    /// </summary>
    /// <remarks>
    /// Supported keys: arch, virt
    /// </remarks>
    public class CONST : AdvancedToken
    {
        public CONST(string key, Operator op, string value) : base(key, op, value)
        {
        }

        public override string Name => "CONST";
    }
}