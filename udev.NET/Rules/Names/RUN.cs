namespace udev.NET.Rules.Names
{
    /// <summary>
    /// Add a program to the list of programs to be executed after processing all the rules for a specific event, depending on <see cref="Token.Key"/>.
    /// </summary>
    /// <remarks>
    /// Supported keys: `program`, `builtin`
    /// </remarks>
    public class RUN : AdvancedToken
    {
        public RUN(string key, Operator op, string value) : base(key, op, value)
        {
        }

        public override string Name => "RUN";
    }
}