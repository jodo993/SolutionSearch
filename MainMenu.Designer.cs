namespace SolutionSearch
{
    partial class MainMenu
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
            this.mmFindSolutionButton = new System.Windows.Forms.Button();
            this.mmAddSolutionButton = new System.Windows.Forms.Button();
            this.mmInventoryButton = new System.Windows.Forms.Button();
            this.mmExitButton = new System.Windows.Forms.Button();
            this.mmEditSolutionButton = new System.Windows.Forms.Button();
            this.mmLibraryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mmFindSolutionButton
            // 
            this.mmFindSolutionButton.Location = new System.Drawing.Point(56, 133);
            this.mmFindSolutionButton.Name = "mmFindSolutionButton";
            this.mmFindSolutionButton.Size = new System.Drawing.Size(95, 23);
            this.mmFindSolutionButton.TabIndex = 0;
            this.mmFindSolutionButton.Text = "Find Solution";
            this.mmFindSolutionButton.UseVisualStyleBackColor = true;
            this.mmFindSolutionButton.Click += new System.EventHandler(this.mmFindSolutionButton_Click);
            // 
            // mmAddSolutionButton
            // 
            this.mmAddSolutionButton.Location = new System.Drawing.Point(56, 162);
            this.mmAddSolutionButton.Name = "mmAddSolutionButton";
            this.mmAddSolutionButton.Size = new System.Drawing.Size(95, 23);
            this.mmAddSolutionButton.TabIndex = 1;
            this.mmAddSolutionButton.Text = "Add Solution";
            this.mmAddSolutionButton.UseVisualStyleBackColor = true;
            this.mmAddSolutionButton.Click += new System.EventHandler(this.mmAddSolutionButton_Click);
            // 
            // mmInventoryButton
            // 
            this.mmInventoryButton.Location = new System.Drawing.Point(56, 220);
            this.mmInventoryButton.Name = "mmInventoryButton";
            this.mmInventoryButton.Size = new System.Drawing.Size(95, 23);
            this.mmInventoryButton.TabIndex = 2;
            this.mmInventoryButton.Text = "Inventory";
            this.mmInventoryButton.UseVisualStyleBackColor = true;
            this.mmInventoryButton.Click += new System.EventHandler(this.mmInventoryButton_Click);
            // 
            // mmExitButton
            // 
            this.mmExitButton.Location = new System.Drawing.Point(56, 249);
            this.mmExitButton.Name = "mmExitButton";
            this.mmExitButton.Size = new System.Drawing.Size(95, 23);
            this.mmExitButton.TabIndex = 3;
            this.mmExitButton.Text = "Exit";
            this.mmExitButton.UseVisualStyleBackColor = true;
            this.mmExitButton.Click += new System.EventHandler(this.mmExitButton_Click);
            // 
            // mmEditSolutionButton
            // 
            this.mmEditSolutionButton.Location = new System.Drawing.Point(56, 191);
            this.mmEditSolutionButton.Name = "mmEditSolutionButton";
            this.mmEditSolutionButton.Size = new System.Drawing.Size(95, 23);
            this.mmEditSolutionButton.TabIndex = 4;
            this.mmEditSolutionButton.Text = "Edit Solution";
            this.mmEditSolutionButton.UseVisualStyleBackColor = true;
            this.mmEditSolutionButton.Click += new System.EventHandler(this.mmEditSolutionButton_Click);
            // 
            // mmLibraryButton
            // 
            this.mmLibraryButton.Location = new System.Drawing.Point(56, 104);
            this.mmLibraryButton.Name = "mmLibraryButton";
            this.mmLibraryButton.Size = new System.Drawing.Size(95, 23);
            this.mmLibraryButton.TabIndex = 5;
            this.mmLibraryButton.Text = "Library";
            this.mmLibraryButton.UseVisualStyleBackColor = true;
            this.mmLibraryButton.Click += new System.EventHandler(this.mmLibraryButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 322);
            this.Controls.Add(this.mmLibraryButton);
            this.Controls.Add(this.mmEditSolutionButton);
            this.Controls.Add(this.mmExitButton);
            this.Controls.Add(this.mmInventoryButton);
            this.Controls.Add(this.mmAddSolutionButton);
            this.Controls.Add(this.mmFindSolutionButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mmFindSolutionButton;
        private System.Windows.Forms.Button mmAddSolutionButton;
        private System.Windows.Forms.Button mmInventoryButton;
        private System.Windows.Forms.Button mmExitButton;
        private System.Windows.Forms.Button mmEditSolutionButton;
        private System.Windows.Forms.Button mmLibraryButton;
    }
}