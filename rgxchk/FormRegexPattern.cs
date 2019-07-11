namespace rgxchk
{
    using System;
    using System.Windows.Forms;

    public partial class FormRegexPattern : Form
    {
        public FormRegexPattern()
        {
            InitializeComponent();
        }

        private void FormRegexPattern_Load(object sender, EventArgs e)
        {
            textBoxPattern.Text = Properties.Settings.Default.Pattern;
        }

        private void FormRegexPattern_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBoxPattern_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Pattern = textBoxPattern.Text;
            Properties.Settings.Default.Save();

            UserInput.Pattern = textBoxPattern.Text;

            FormManager.Matches.UpdateMatches();
            FormManager.GroupedMatches.UpdateMatches();
        }
    }
}
