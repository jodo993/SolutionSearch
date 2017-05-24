namespace SolutionSearch
{
    partial class FindSolutionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fsKeywordTextBox = new System.Windows.Forms.TextBox();
            this.fsProblemListBox = new System.Windows.Forms.ListBox();
            this.fsSearchButton = new System.Windows.Forms.Button();
            this.fsSelectButton = new System.Windows.Forms.Button();
            this.fsExitButton = new System.Windows.Forms.Button();
            this.fsMainMenuButton = new System.Windows.Forms.Button();
            this.fsSubProblemListBox = new System.Windows.Forms.ListBox();
            this.fsKeyword3TextBox = new System.Windows.Forms.TextBox();
            this.fsKeyword4TextBox = new System.Windows.Forms.TextBox();
            this.fsKeyword2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyword";
            // 
            // fsKeywordTextBox
            // 
            this.fsKeywordTextBox.Location = new System.Drawing.Point(24, 35);
            this.fsKeywordTextBox.Name = "fsKeywordTextBox";
            this.fsKeywordTextBox.Size = new System.Drawing.Size(141, 20);
            this.fsKeywordTextBox.TabIndex = 1;
            // 
            // fsProblemListBox
            // 
            this.fsProblemListBox.FormattingEnabled = true;
            this.fsProblemListBox.Location = new System.Drawing.Point(24, 123);
            this.fsProblemListBox.Name = "fsProblemListBox";
            this.fsProblemListBox.Size = new System.Drawing.Size(119, 147);
            this.fsProblemListBox.TabIndex = 2;
            // 
            // fsSearchButton
            // 
            this.fsSearchButton.Location = new System.Drawing.Point(365, 46);
            this.fsSearchButton.Name = "fsSearchButton";
            this.fsSearchButton.Size = new System.Drawing.Size(75, 36);
            this.fsSearchButton.TabIndex = 3;
            this.fsSearchButton.Text = "Search";
            this.fsSearchButton.UseVisualStyleBackColor = true;
            // 
            // fsSelectButton
            // 
            this.fsSelectButton.Location = new System.Drawing.Point(365, 123);
            this.fsSelectButton.Name = "fsSelectButton";
            this.fsSelectButton.Size = new System.Drawing.Size(75, 23);
            this.fsSelectButton.TabIndex = 4;
            this.fsSelectButton.Text = "Select";
            this.fsSelectButton.UseVisualStyleBackColor = true;
            // 
            // fsExitButton
            // 
            this.fsExitButton.Location = new System.Drawing.Point(365, 247);
            this.fsExitButton.Name = "fsExitButton";
            this.fsExitButton.Size = new System.Drawing.Size(75, 23);
            this.fsExitButton.TabIndex = 5;
            this.fsExitButton.Text = "Exit";
            this.fsExitButton.UseVisualStyleBackColor = true;
            // 
            // fsMainMenuButton
            // 
            this.fsMainMenuButton.Location = new System.Drawing.Point(365, 218);
            this.fsMainMenuButton.Name = "fsMainMenuButton";
            this.fsMainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.fsMainMenuButton.TabIndex = 6;
            this.fsMainMenuButton.Text = "Main Menu";
            this.fsMainMenuButton.UseVisualStyleBackColor = true;
            // 
            // fsSubProblemListBox
            // 
            this.fsSubProblemListBox.FormattingEnabled = true;
            this.fsSubProblemListBox.Location = new System.Drawing.Point(165, 123);
            this.fsSubProblemListBox.Name = "fsSubProblemListBox";
            this.fsSubProblemListBox.Size = new System.Drawing.Size(179, 147);
            this.fsSubProblemListBox.TabIndex = 7;
            // 
            // fsKeyword3TextBox
            // 
            this.fsKeyword3TextBox.Location = new System.Drawing.Point(24, 62);
            this.fsKeyword3TextBox.Name = "fsKeyword3TextBox";
            this.fsKeyword3TextBox.Size = new System.Drawing.Size(141, 20);
            this.fsKeyword3TextBox.TabIndex = 8;
            // 
            // fsKeyword4TextBox
            // 
            this.fsKeyword4TextBox.Location = new System.Drawing.Point(182, 62);
            this.fsKeyword4TextBox.Name = "fsKeyword4TextBox";
            this.fsKeyword4TextBox.Size = new System.Drawing.Size(141, 20);
            this.fsKeyword4TextBox.TabIndex = 10;
            // 
            // fsKeyword2TextBox
            // 
            this.fsKeyword2TextBox.Location = new System.Drawing.Point(182, 35);
            this.fsKeyword2TextBox.Name = "fsKeyword2TextBox";
            this.fsKeyword2TextBox.Size = new System.Drawing.Size(141, 20);
            this.fsKeyword2TextBox.TabIndex = 11;
            // 
            // FindSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 303);
            this.Controls.Add(this.fsKeyword2TextBox);
            this.Controls.Add(this.fsKeyword4TextBox);
            this.Controls.Add(this.fsKeyword3TextBox);
            this.Controls.Add(this.fsSubProblemListBox);
            this.Controls.Add(this.fsMainMenuButton);
            this.Controls.Add(this.fsExitButton);
            this.Controls.Add(this.fsSelectButton);
            this.Controls.Add(this.fsSearchButton);
            this.Controls.Add(this.fsProblemListBox);
            this.Controls.Add(this.fsKeywordTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FindSolutionForm";
            this.Text = "FindSolutionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fsKeywordTextBox;
        private System.Windows.Forms.ListBox fsProblemListBox;
        private System.Windows.Forms.Button fsSearchButton;
        private System.Windows.Forms.Button fsSelectButton;
        private System.Windows.Forms.Button fsExitButton;
        private System.Windows.Forms.Button fsMainMenuButton;
        private System.Windows.Forms.ListBox fsSubProblemListBox;
        private System.Windows.Forms.TextBox fsKeyword3TextBox;
        private System.Windows.Forms.TextBox fsKeyword4TextBox;
        private System.Windows.Forms.TextBox fsKeyword2TextBox;
    }
}