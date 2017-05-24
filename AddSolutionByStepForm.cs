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
    public partial class AddSolutionByStepForm : Form
    {
        // Open connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:]\Users\Jdo\Desktop\SolutionSearch\SolutionSearch\SolutionDatabase.mdf;Integrated Security=True");
        public AddSolutionByStepForm()
        {
            InitializeComponent();
        }

        // Clear all keyword textboxes
        private void asbsKeywordClearButton_Click(object sender, EventArgs e)
        {
            asbsKeywordOneTextBox.Clear();
            asbsKeywordTwoTextBox.Clear();
            asbsKeywordThreeTextBox.Clear();
            asbsKeywordFourTextBox.Clear();
            asbsKeywordFiveTextBox.Clear();
        }

        // Save solution into database
        private void asbsSaveButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into SolutionDatabase values('"+asbsKeywordOneTextBox.Text+ "','" + asbsKeywordTwoTextBox.Text + "','" + asbsKeywordThreeTextBox.Text + "','" + asbsKeywordFourTextBox.Text + "','" + asbsKeywordFiveTextBox.Text + "','" + asbsStepOneTextBox.Text + "','" + asbsStepTwoTextBox.Text + "','" + asbsStepThreeTextBox.Text + "','" + asbsStepFourTextBox.Text + "','" + asbsStepFiveTextBox.Text + "','" + asbsStepSixTextBox.Text + "','" + asbsStepSevenTextBox.Text + "','" + asbsStepEightTextBox.Text+"')";
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Thank you, your submission has been saved.");
        }

        // Clear all steps textboxes
        private void asbsStepsClearButton_Click(object sender, EventArgs e)
        {
            asbsStepOneTextBox.Clear();
            asbsStepTwoTextBox.Clear();
            asbsStepThreeTextBox.Clear();
            asbsStepFourTextBox.Clear();
            asbsStepFiveTextBox.Clear();
            asbsStepSixTextBox.Clear();
            asbsStepSevenTextBox.Clear();
            asbsStepEightTextBox.Clear();
        }

        // Bring user back to main menu form
        private void asbsMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.ShowDialog();

            this.Close();
        }

        // Closes program
        private void asbsExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
