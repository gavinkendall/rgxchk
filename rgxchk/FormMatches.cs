namespace rgxchk
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class FormMatches : Form
    {
        public FormMatches()
        {
            InitializeComponent();
        }

        private void FormMatches_Load(object sender, EventArgs e)
        {

        }

        private void FormMatches_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        public void UpdateMatches()
        {
            if (UserInput.Check())
            {
                if (UserInput.Matches != null)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (Match match in UserInput.Matches)
                    {
                        if (match.Value.Length > 0)
                        {
                            sb.AppendLine(match.Value);
                        }
                    }

                    textBoxMatches.Text = sb.ToString();
                }
            }
        }
    }
}
