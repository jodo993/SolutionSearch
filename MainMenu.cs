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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mmFindSolutionButton_Click(object sender, EventArgs e)
        {
            // Hides the window after choice is made
            this.Hide();

            // Open the find solution form
            FindSolutionForm findSolutionForm = new FindSolutionForm();
            findSolutionForm.ShowDialog();

            this.Close();
        }

        private void mmAddSolutionButton_Click(object sender, EventArgs e)
        {
            // Hides the window after choice is made
            this.Hide();

            // Open the add solution form
            AddSolutionForm addSolutionForm = new AddSolutionForm();
            addSolutionForm.ShowDialog();

            this.Close();
        }

        private void mmEditSolutionButton_Click(object sender, EventArgs e)
        {
            // Hides the window after choice is made
            this.Hide();

            // Open the edit solution form
            EditSolutionForm editSolutionForm = new EditSolutionForm();
            editSolutionForm.ShowDialog();

            this.Close();
        }

        private void mmInventoryButton_Click(object sender, EventArgs e)
        {
            // Hides the window after choice is made
            this.Hide();

            // Open the inventory form
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog();

            this.Close();
        }

        // Exit the program
        private void mmExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
