namespace ELH.CleanSource
{
    partial class Form1
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
            this.DirectorySelectButton = new System.Windows.Forms.Button();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.CleanSourceButton = new System.Windows.Forms.Button();
            this.FilePatternBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RefreshMatchesButton = new System.Windows.Forms.Button();
            this.DirectoryPatternBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MatchedFileView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DirectorySelectButton
            // 
            this.DirectorySelectButton.Location = new System.Drawing.Point(12, 12);
            this.DirectorySelectButton.Name = "DirectorySelectButton";
            this.DirectorySelectButton.Size = new System.Drawing.Size(106, 23);
            this.DirectorySelectButton.TabIndex = 0;
            this.DirectorySelectButton.Text = "Select a Directory";
            this.DirectorySelectButton.UseVisualStyleBackColor = true;
            this.DirectorySelectButton.Click += new System.EventHandler(this.DirectorySelectButton_Click);
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(124, 17);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(0, 13);
            this.DirectoryLabel.TabIndex = 1;
            // 
            // CleanSourceButton
            // 
            this.CleanSourceButton.Location = new System.Drawing.Point(474, 415);
            this.CleanSourceButton.Name = "CleanSourceButton";
            this.CleanSourceButton.Size = new System.Drawing.Size(109, 23);
            this.CleanSourceButton.TabIndex = 2;
            this.CleanSourceButton.Text = "Clean Source Tree";
            this.CleanSourceButton.UseVisualStyleBackColor = true;
            this.CleanSourceButton.Click += new System.EventHandler(this.CleanSourceButton_Click);
            // 
            // FilePatternBox
            // 
            this.FilePatternBox.Location = new System.Drawing.Point(12, 65);
            this.FilePatternBox.Multiline = true;
            this.FilePatternBox.Name = "FilePatternBox";
            this.FilePatternBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FilePatternBox.Size = new System.Drawing.Size(571, 48);
            this.FilePatternBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Matches";
            // 
            // RefreshMatchesButton
            // 
            this.RefreshMatchesButton.Location = new System.Drawing.Point(474, 191);
            this.RefreshMatchesButton.Name = "RefreshMatchesButton";
            this.RefreshMatchesButton.Size = new System.Drawing.Size(109, 23);
            this.RefreshMatchesButton.TabIndex = 7;
            this.RefreshMatchesButton.Text = "Refresh Matches";
            this.RefreshMatchesButton.UseVisualStyleBackColor = true;
            this.RefreshMatchesButton.Click += new System.EventHandler(this.RefreshMatchesButton_Click);
            // 
            // DirectoryPatternBox
            // 
            this.DirectoryPatternBox.Location = new System.Drawing.Point(12, 137);
            this.DirectoryPatternBox.Multiline = true;
            this.DirectoryPatternBox.Name = "DirectoryPatternBox";
            this.DirectoryPatternBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DirectoryPatternBox.Size = new System.Drawing.Size(571, 48);
            this.DirectoryPatternBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Directory Filter";
            // 
            // MatchedFileView
            // 
            this.MatchedFileView.Location = new System.Drawing.Point(18, 220);
            this.MatchedFileView.Multiline = true;
            this.MatchedFileView.Name = "MatchedFileView";
            this.MatchedFileView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MatchedFileView.Size = new System.Drawing.Size(565, 189);
            this.MatchedFileView.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.MatchedFileView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirectoryPatternBox);
            this.Controls.Add(this.RefreshMatchesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePatternBox);
            this.Controls.Add(this.CleanSourceButton);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.DirectorySelectButton);
            this.Name = "Form1";
            this.Text = "Source Tree Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DirectorySelectButton;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Button CleanSourceButton;
        private System.Windows.Forms.TextBox FilePatternBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RefreshMatchesButton;
        private System.Windows.Forms.TextBox DirectoryPatternBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MatchedFileView;
    }
}

