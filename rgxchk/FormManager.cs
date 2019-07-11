namespace rgxchk
{
    public static class FormManager
    {
        public static FormRegexPattern RegexPattern { get; set; }
        public static FormDataInput DataSample { get; set; }
        public static FormMatches Matches { get; set; }
        public static FormGroupedMatches GroupedMatches { get; set; }

        public static void Initialize()
        {
            RegexPattern = new FormRegexPattern();
            DataSample = new FormDataInput();
            Matches = new FormMatches();
            GroupedMatches = new FormGroupedMatches();

            RegexPattern.Show();
            DataSample.Show();
            Matches.Show();
            GroupedMatches.Show();
        }
    }
}
