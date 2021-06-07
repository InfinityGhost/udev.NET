using System.Collections.Generic;

namespace udev.NET.Rules
{
    public class Rule
    {
        public Rule()
        {
        }

        public Rule(params Token[] tokens)
        {
            Tokens = tokens;
        }

        public IEnumerable<Token> Tokens { set; get; }

        public override string ToString() => string.Join(", ", Tokens);
        public static implicit operator string(Rule rule) => rule.ToString();
    }
}
