namespace rgxchk
{
    partial class FormSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSample
            // 
            this.textBoxSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSample.Location = new System.Drawing.Point(12, 12);
            this.textBoxSample.Multiline = true;
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSample.Size = new System.Drawing.Size(289, 177);
            this.textBoxSample.TabIndex = 0;
            this.textBoxSample.WordWrap = false;
            this.textBoxSample.TextChanged += new System.EventHandler(this.textBoxSample_TextChanged);
            // 
            // FormSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 201);
            this.Controls.Add(this.textBoxSample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(329, 0);
            this.Name = "FormSample";
            this.ShowInTaskbar = false;
            this.Text = "Dynamic Regex Validator - Sample";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSample_FormClosing);
            this.Load += new System.EventHandler(this.FormSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSample;
    }
}