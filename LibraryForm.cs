using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SolutionSearch
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void lfSearchStatusButton_Click(object sender, EventArgs e)
        {

        }

        private void lfCheckOutButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("itemStatus.txt");

            outputFile.WriteLine(checkOutTextBox.Text, "out");
            outputFile.Close();
        }

        private void lfCheckInButton_Click(object sender, EventArgs e)
        {

        }

        private void lfMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.ShowDialog();

            this.Close();
        }

        private void lfExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
