namespace rgxchk
{
    public static class FormManager
    {
        public static FormPattern Pattern { get; set; }
        public static FormSample Sample { get; set; }
        public static FormMatches Match { get; set; }

        public static void Initialize()
        {
            Pattern = new FormPattern();
            Sample = new FormSample();
            Match = new FormMatches();

            Pattern.Show();
            Sample.Show();
            Match.Show();
        }
    }
}
