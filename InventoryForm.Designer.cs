namespace SolutionSearch
{
    partial class InventoryForm
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
            this.ifCheckInventoryButton = new System.Windows.Forms.Button();
            this.ifAddInventoryButton = new System.Windows.Forms.Button();
            this.ifRemoveInventoryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ifMainMenuButton = new System.Windows.Forms.Button();
            this.ifExitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ifCheckInventoryButton
            // 
            this.ifCheckInventoryButton.Location = new System.Drawing.Point(119, 312);
            this.ifCheckInventoryButton.Name = "ifCheckInventoryButton";
            this.ifCheckInventoryButton.Size = new System.Drawing.Size(75, 23);
            this.ifCheckInventoryButton.TabIndex = 0;
            this.ifCheckInventoryButton.Text = "Check";
            this.ifCheckInventoryButton.UseVisualStyleBackColor = true;
            // 
            // ifAddInventoryButton
            // 
            this.ifAddInventoryButton.Location = new System.Drawing.Point(420, 391);
            this.ifAddInventoryButton.Name = "ifAddInventoryButton";
            this.ifAddInventoryButton.Size = new System.Drawing.Size(75, 23);
            this.ifAddInventoryButton.TabIndex = 1;
            this.ifAddInventoryButton.Text = "Add";
            this.ifAddInventoryButton.UseVisualStyleBackColor = true;
            // 
            // ifRemoveInventoryButton
            // 
            this.ifRemoveInventoryButton.Location = new System.Drawing.Point(306, 312);
            this.ifRemoveInventoryButton.Name = "ifRemoveInventoryButton";
            this.ifRemoveInventoryButton.Size = new System.Drawing.Size(75, 23);
            this.ifRemoveInventoryButton.TabIndex = 2;
            this.ifRemoveInventoryButton.Text = "Remove";
            this.ifRemoveInventoryButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tag ID";
            // 
            // ifMainMenuButton
            // 
            this.ifMainMenuButton.Location = new System.Drawing.Point(130, 391);
            this.ifMainMenuButton.Name = "ifMainMenuButton";
            this.ifMainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.ifMainMenuButton.TabIndex = 5;
            this.ifMainMenuButton.Text = "Main Menu";
            this.ifMainMenuButton.UseVisualStyleBackColor = true;
            // 
            // ifExitButton
            // 
            this.ifExitButton.Location = new System.Drawing.Point(258, 391);
            this.ifExitButton.Name = "ifExitButton";
            this.ifExitButton.Size = new System.Drawing.Size(75, 23);
            this.ifExitButton.TabIndex = 6;
            this.ifExitButton.Text = "Exit";
            this.ifExitButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(530, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Inventory";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 218);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Inventory";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ifExitButton);
            this.Controls.Add(this.ifCheckInventoryButton);
            this.Controls.Add(this.ifMainMenuButton);
            this.Controls.Add(this.ifRemoveInventoryButton);
            this.Controls.Add(this.ifAddInventoryButton);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ifCheckInventoryButton;
        private System.Windows.Forms.Button ifAddInventoryButton;
        private System.Windows.Forms.Button ifRemoveInventoryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ifMainMenuButton;
        private System.Windows.Forms.Button ifExitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}