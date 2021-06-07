using System;

namespace udev.NET.Rules
{
    public class Token
    {
        public Token(string key, Operator op, string value)
        {
            Key = key;
            Operator = op;
            Value = value;
        }

        public string Key { set; get; }
        public Operator Operator { set; get; }
        public string Value { set; get; }

        public override string ToString()
        {
            return Key + Operator.Format() + $"\"{Value}\"";
        }
    }
}