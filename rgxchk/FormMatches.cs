namespace rgxchk
{
    using System;
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
            treeViewMatches.Nodes.Clear();

            if (UserInput.Check())
            {
                if (UserInput.Matches != null)
                {
                    foreach (Match match in UserInput.Matches)
                    {
                        if (match.Value.Length > 0)
                        {
                            TreeNode node = new TreeNode("[" + match.Value + "]");
                            node.Name = node.Text;

                            AddNode(node, 0, false);

                            int nodeIndex = treeViewMatches.Nodes.Count - 1;

                            if (match.Groups.Count > 1)
                            {
                                for (int i = 1; i < match.Groups.Count; i++)
                                {
                                    node = new TreeNode(UserInput.Regex.GroupNameFromNumber(i) + ": [" +
                                                        match.Groups[i].Value + "]");
                                    node.Name = node.Text;

                                    AddNode(node, nodeIndex, true);

                                    int captureCount = match.Groups[i].Captures.Count;

                                    if (captureCount > 1)
                                    {
                                        for (int j = 0; j < captureCount; j++)
                                        {
                                            node = new TreeNode(match.Groups[i].Captures[j].Value);
                                            node.Name = node.Text;

                                            if (!treeViewMatches.Nodes[nodeIndex].Nodes[i - 1].Nodes
                                                .ContainsKey(node.Name))
                                            {
                                                treeViewMatches.Nodes[nodeIndex].Nodes[i - 1].Nodes.Add(node);
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

        private void AddNode(TreeNode node, int index, bool nextLevel)
        {
            if (!nextLevel)
            {
                if (!treeViewMatches.Nodes.ContainsKey(node.Name))
                {
                    treeViewMatches.Nodes.Add(node);
                }
            }
            else
            {
                if (!treeViewMatches.Nodes[index].Nodes.ContainsKey(node.Name))
                {
                    treeViewMatches.Nodes[index].Nodes.Add(node);
                }
            }
        }
    }
}
