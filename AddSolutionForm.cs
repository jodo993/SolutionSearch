using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionSearch
{
    public partial class AddSolutionForm : Form
    {
        public AddSolutionForm()
        {
            InitializeComponent();
        }

        private void asGoButton_Click(object sender, EventArgs e)
        {
            // If add by step check is selected, hide current form and show add by step form
            if (asAddByStepCheckBox.Checked)
            {
                this.Hide();

                AddSolutionByStepForm addSolutionByStep = new AddSolutionByStepForm();
                addSolutionByStep.ShowDialog();

                this.Close();
            }
            // If add by paragraph check is selected, hide current form and show add by paragraph form
            else if(asAddByParagraphCheckBox.Checked)
            {
                this.Hide();

                AddSolutionByParagraphForm addSolutionByParagraph = new AddSolutionByParagraphForm();
                addSolutionByParagraph.ShowDialog();

                this.Close();
            }
            else
            {
                // Prompt  user to pick a choice
                MessageBox.Show("Please make a selection first.");
            }
        }

        // Go back to main menu
        private void asMainMenuButton_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();

            // Go to main menu form
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.ShowDialog();

            this.Close();
        }

        // Closes program
        private void asExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
