namespace rgxchk
{
    using System.Text.RegularExpressions;

    public static class UserInput
    {
        public static Regex Regex { get; set; }
        public static string Sample { get; set; }
        public static string Pattern { get; set; }
        public static MatchCollection Matches { get; set; }

        public static bool Check()
        {
            try
            {
                if (string.IsNullOrEmpty(Pattern) || string.IsNullOrEmpty(Sample))
                {
                    return false;
                }

                Regex = new Regex(Pattern);

                Matches = Regex.Matches(Sample);

                return Regex.IsMatch(Sample);
            }
            catch
            {
                return false;
            }
        }
    }
}
