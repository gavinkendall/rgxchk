namespace rgxchk
{
    partial class FormDataInput
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
            this.textBoxSample.Location = new System.Drawing.Point(14, 14);
            this.textBoxSample.MaxLength = 999999999;
            this.textBoxSample.Multiline = true;
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSample.Size = new System.Drawing.Size(336, 204);
            this.textBoxSample.TabIndex = 0;
            this.textBoxSample.TabStop = false;
            this.textBoxSample.WordWrap = false;
            this.textBoxSample.TextChanged += new System.EventHandler(this.textBoxSample_TextChanged);
            // 
            // FormDataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 232);
            this.Controls.Add(this.textBoxSample);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(381, 39);
            this.Name = "FormDataInput";
            this.ShowInTaskbar = false;
            this.Text = "Data Input";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDataInput_FormClosing);
            this.Load += new System.EventHandler(this.FormDataInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSample;
    }
}