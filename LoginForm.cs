using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SolutionSearch
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Log the user into the program if correct username and password is entered
        private void lmLoginButton_Click(object sender, EventArgs e)
        {
            // Obtain data from log in textboxes
            string username = lmUsernameTextBox.Text;
            string password = lmPasswordTextBox.Text;

            // Compares UN and PW with built in UN and PW. Log in if match
            if (username == "teacher" && password == "webber")
            {
                // Hides the login form after successful attempt
                this.Hide();

                // Creates main menu form
                MainMenu mainMenuForm = new MainMenu();
                mainMenuForm.ShowDialog();

                this.Close();
            }
            else
                // Shows incorrect label if log in attempt fails
                lmIncorrectLoginLabel.Visible = true;
        }

        // Clear username and login textboxes
        private void lmClearButton_Click(object sender, EventArgs e)
        {
            lmUsernameTextBox.Clear();
            lmPasswordTextBox.Clear();
            lmIncorrectLoginLabel.Visible = false;
        }

        // Close and exit the application
        private void lmExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lmSignUpButton_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=. \SQLEXPRESS;AttachDbFilename=C:\Users\");
            //SqlDataAdapter sqlDataAdapter = new SqlConnection("Select Count(*) From LoginTable where Username='" + lmUsernameTextBox.Text + "' and Password ='" + lmPasswordTextBox.Text + "'", connection);
        }
    }
}
