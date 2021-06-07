namespace udev.NET.Rules.Names
{
    /// <summary>
    /// Import a set of variables as device properties, depending on <see cref="Token.Key"/>.
    /// </summary>
    /// <remarks>
    /// Supported keys: `program`, `builtin`, `file`, `db`, `cmdline`, `parent`
    /// </remarks>
    public class IMPORT : AdvancedToken
    {
        public IMPORT(string key, Operator op, string value) : base(key, op, value)
        {
        }

        public override string Name => "IMPORT";
    }
}