namespace KMITool
{
    partial class SuccessForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenButton = new Button();
            CopyButton = new Button();
            LinkTextBox = new TextBox();
            SuspendLayout();
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(12, 12);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(75, 23);
            OpenButton.TabIndex = 0;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += onOpenClick;
            // 
            // CopyButton
            // 
            CopyButton.Location = new Point(93, 12);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(75, 23);
            CopyButton.TabIndex = 1;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += onCopyClick;
            // 
            // LinkTextBox
            // 
            LinkTextBox.Location = new Point(174, 12);
            LinkTextBox.Name = "LinkTextBox";
            LinkTextBox.Size = new Size(148, 23);
            LinkTextBox.TabIndex = 2;
            // 
            // SuccessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 46);
            Controls.Add(LinkTextBox);
            Controls.Add(CopyButton);
            Controls.Add(OpenButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SuccessForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "KMI Tool";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenButton;
        private Button CopyButton;
        private TextBox LinkTextBox;
    }
}