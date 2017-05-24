namespace SolutionSearch
{
    partial class AddSolutionForm
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
            this.asAddByStepCheckBox = new System.Windows.Forms.CheckBox();
            this.asAddByParagraphCheckBox = new System.Windows.Forms.CheckBox();
            this.asGoButton = new System.Windows.Forms.Button();
            this.asMainMenuButton = new System.Windows.Forms.Button();
            this.asExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please pick an option.";
            // 
            // asAddByStepCheckBox
            // 
            this.asAddByStepCheckBox.AutoSize = true;
            this.asAddByStepCheckBox.Location = new System.Drawing.Point(82, 41);
            this.asAddByStepCheckBox.Name = "asAddByStepCheckBox";
            this.asAddByStepCheckBox.Size = new System.Drawing.Size(89, 17);
            this.asAddByStepCheckBox.TabIndex = 2;
            this.asAddByStepCheckBox.Text = "Add by Steps";
            this.asAddByStepCheckBox.UseVisualStyleBackColor = true;
            // 
            // asAddByParagraphCheckBox
            // 
            this.asAddByParagraphCheckBox.AutoSize = true;
            this.asAddByParagraphCheckBox.Location = new System.Drawing.Point(82, 67);
            this.asAddByParagraphCheckBox.Name = "asAddByParagraphCheckBox";
            this.asAddByParagraphCheckBox.Size = new System.Drawing.Size(111, 17);
            this.asAddByParagraphCheckBox.TabIndex = 3;
            this.asAddByParagraphCheckBox.Text = "Add by Paragraph";
            this.asAddByParagraphCheckBox.UseVisualStyleBackColor = true;
            // 
            // asGoButton
            // 
            this.asGoButton.Location = new System.Drawing.Point(12, 89);
            this.asGoButton.Name = "asGoButton";
            this.asGoButton.Size = new System.Drawing.Size(75, 23);
            this.asGoButton.TabIndex = 4;
            this.asGoButton.Text = "Go";
            this.asGoButton.UseVisualStyleBackColor = true;
            this.asGoButton.Click += new System.EventHandler(this.asGoButton_Click);
            // 
            // asMainMenuButton
            // 
            this.asMainMenuButton.Location = new System.Drawing.Point(93, 89);
            this.asMainMenuButton.Name = "asMainMenuButton";
            this.asMainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.asMainMenuButton.TabIndex = 5;
            this.asMainMenuButton.Text = "Main Menu";
            this.asMainMenuButton.UseVisualStyleBackColor = true;
            this.asMainMenuButton.Click += new System.EventHandler(this.asMainMenuButton_Click);
            // 
            // asExitButton
            // 
            this.asExitButton.Location = new System.Drawing.Point(174, 89);
            this.asExitButton.Name = "asExitButton";
            this.asExitButton.Size = new System.Drawing.Size(75, 23);
            this.asExitButton.TabIndex = 6;
            this.asExitButton.Text = "Exit";
            this.asExitButton.UseVisualStyleBackColor = true;
            this.asExitButton.Click += new System.EventHandler(this.asExitButton_Click);
            // 
            // AddSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 137);
            this.Controls.Add(this.asExitButton);
            this.Controls.Add(this.asMainMenuButton);
            this.Controls.Add(this.asGoButton);
            this.Controls.Add(this.asAddByParagraphCheckBox);
            this.Controls.Add(this.asAddByStepCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "AddSolutionForm";
            this.Text = "AddSolutionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox asAddByStepCheckBox;
        private System.Windows.Forms.CheckBox asAddByParagraphCheckBox;
        private System.Windows.Forms.Button asGoButton;
        private System.Windows.Forms.Button asMainMenuButton;
        private System.Windows.Forms.Button asExitButton;
    }
}