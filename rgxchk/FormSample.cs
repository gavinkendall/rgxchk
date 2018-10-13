namespace rgxchk
{
    using System;
    using System.Windows.Forms;

    public partial class FormSample : Form
    {
        public FormSample()
        {
            InitializeComponent();
        }

        private void FormSample_Load(object sender, EventArgs e)
        {
            textBoxSample.Text = Properties.Settings.Default.Sample;
        }

        private void FormSample_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBoxSample_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Sample = textBoxSample.Text;
            Properties.Settings.Default.Save();

            UserInput.Sample = textBoxSample.Text;

            FormManager.Match.UpdateMatches();
        }
    }
}
