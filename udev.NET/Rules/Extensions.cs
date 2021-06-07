namespace udev.NET.Rules
{
    public static class Extensions
    {
        public static string Format(this Operator value)
        {
            switch (value)
            {
                case Operator.Equal:
                    return "==";
                case Operator.Inequal:
                    return "!=";
                case Operator.Assign:
                    return "=";
                case Operator.Add:
                    return "+=";
                case Operator.Remove:
                    return "-=";
                case Operator.AssignFinal:
                    return ":=";
                default:
                    return null;
            }
        }
    }
}