namespace SolutionSearch
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lmUsernameTextBox = new System.Windows.Forms.TextBox();
            this.lmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.lmLoginButton = new System.Windows.Forms.Button();
            this.lmClearButton = new System.Windows.Forms.Button();
            this.lmExitButton = new System.Windows.Forms.Button();
            this.lmIncorrectLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lmUsernameTextBox
            // 
            this.lmUsernameTextBox.Location = new System.Drawing.Point(129, 59);
            this.lmUsernameTextBox.Name = "lmUsernameTextBox";
            this.lmUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lmUsernameTextBox.TabIndex = 3;
            this.lmUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lmPasswordTextBox
            // 
            this.lmPasswordTextBox.Location = new System.Drawing.Point(129, 92);
            this.lmPasswordTextBox.Name = "lmPasswordTextBox";
            this.lmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.lmPasswordTextBox.TabIndex = 4;
            this.lmPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lmLoginButton
            // 
            this.lmLoginButton.Location = new System.Drawing.Point(33, 133);
            this.lmLoginButton.Name = "lmLoginButton";
            this.lmLoginButton.Size = new System.Drawing.Size(75, 23);
            this.lmLoginButton.TabIndex = 5;
            this.lmLoginButton.Text = "Log In";
            this.lmLoginButton.UseVisualStyleBackColor = true;
            this.lmLoginButton.Click += new System.EventHandler(this.lmLoginButton_Click);
            // 
            // lmClearButton
            // 
            this.lmClearButton.Location = new System.Drawing.Point(114, 133);
            this.lmClearButton.Name = "lmClearButton";
            this.lmClearButton.Size = new System.Drawing.Size(75, 23);
            this.lmClearButton.TabIndex = 6;
            this.lmClearButton.Text = "Clear";
            this.lmClearButton.UseVisualStyleBackColor = true;
            this.lmClearButton.Click += new System.EventHandler(this.lmClearButton_Click);
            // 
            // lmExitButton
            // 
            this.lmExitButton.Location = new System.Drawing.Point(195, 133);
            this.lmExitButton.Name = "lmExitButton";
            this.lmExitButton.Size = new System.Drawing.Size(75, 23);
            this.lmExitButton.TabIndex = 7;
            this.lmExitButton.Text = "Exit";
            this.lmExitButton.UseVisualStyleBackColor = true;
            this.lmExitButton.Click += new System.EventHandler(this.lmExitButton_Click);
            // 
            // lmIncorrectLoginLabel
            // 
            this.lmIncorrectLoginLabel.AutoSize = true;
            this.lmIncorrectLoginLabel.Location = new System.Drawing.Point(49, 32);
            this.lmIncorrectLoginLabel.Name = "lmIncorrectLoginLabel";
            this.lmIncorrectLoginLabel.Size = new System.Drawing.Size(200, 13);
            this.lmIncorrectLoginLabel.TabIndex = 8;
            this.lmIncorrectLoginLabel.Text = "Sorry, username or password is incorrect.";
            this.lmIncorrectLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lmIncorrectLoginLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 212);
            this.Controls.Add(this.lmIncorrectLoginLabel);
            this.Controls.Add(this.lmExitButton);
            this.Controls.Add(this.lmClearButton);
            this.Controls.Add(this.lmLoginButton);
            this.Controls.Add(this.lmPasswordTextBox);
            this.Controls.Add(this.lmUsernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lmUsernameTextBox;
        private System.Windows.Forms.TextBox lmPasswordTextBox;
        private System.Windows.Forms.Button lmLoginButton;
        private System.Windows.Forms.Button lmClearButton;
        private System.Windows.Forms.Button lmExitButton;
        private System.Windows.Forms.Label lmIncorrectLoginLabel;
    }
}

