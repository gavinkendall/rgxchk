namespace rgxchk
{
    using System;
    using System.Windows.Forms;

    public partial class FormDataInput : Form
    {
        public FormDataInput()
        {
            InitializeComponent();
        }

        private void FormDataInput_Load(object sender, EventArgs e)
        {
            textBoxSample.Text = Properties.Settings.Default.Sample;
        }

        private void FormDataInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBoxSample_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Sample = textBoxSample.Text;
            Properties.Settings.Default.Save();

            UserInput.Sample = textBoxSample.Text;

            FormManager.Matches.UpdateMatches();
            FormManager.GroupedMatches.UpdateMatches();
        }
    }
}
