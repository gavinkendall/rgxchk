namespace rgxchk
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class FormGroupedMatches : Form
    {
        public FormGroupedMatches()
        {
            InitializeComponent();
        }

        private void FormGroupedMatches_Load(object sender, EventArgs e)
        {

        }

        private void FormGroupedMatches_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        public void UpdateMatches()
        {
            treeViewMatches.Nodes.Clear();

            if (UserInput.Check())
            {
                if (UserInput.Matches != null)
                {
                    foreach (Match match in UserInput.Matches)
                    {
                        if (match.Value.Length > 0)
                        {
                            int nodeIndex = treeViewMatches.Nodes.Count - 1;

                            if (nodeIndex < 0)
                            {
                                nodeIndex = 0;
                            }

                            if (match.Groups.Count > 0)
                            {
                                for (int i = 0; i < match.Groups.Count; i++)
                                {
                                    TreeNode node = new TreeNode(UserInput.Regex.GroupNameFromNumber(i));
                                    node.Name = node.Text;

                                    AddNode(node);

                                    int captureCount = match.Groups[i].Captures.Count;

                                    if (captureCount > 0)
                                    {
                                        for (int j = 0; j < captureCount; j++)
                                        {
                                            node = new TreeNode(match.Groups[i].Captures[j].Value);
                                            node.Name = node.Text;

                                            if (!treeViewMatches.Nodes[nodeIndex].Nodes.ContainsKey(node.Name))
                                            {
                                                treeViewMatches.Nodes[nodeIndex].Nodes.Add(node);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void AddNode(TreeNode node)
        {
            if (!treeViewMatches.Nodes.ContainsKey(node.Name))
            {
                treeViewMatches.Nodes.Add(node);
            }
        }
    }
}
