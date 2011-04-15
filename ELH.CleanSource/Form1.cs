using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace ELH.CleanSource
{
    public partial class Form1 : Form
    {
        private DirectoryInfo _directoryLocation;

        public Form1()
        {
            InitializeComponent();
            FilePatternBox.Text = ConfigurationManager.AppSettings["FilePatterns"];
            DirectoryPatternBox.Text = ConfigurationManager.AppSettings["DirectoryPatterns"];
        }

        private void DirectorySelectButton_Click(object sender, EventArgs e)
        {
            var directorySelector = new FolderBrowserDialog();
            directorySelector.Description = "Select the directory that holds your source code that you want to clean.";
            directorySelector.ShowNewFolderButton = false;

            var directoryResult = directorySelector.ShowDialog();

            if (directoryResult == DialogResult.OK)
            {
                // let's process this
                _directoryLocation = new DirectoryInfo(directorySelector.SelectedPath);
                DirectoryLabel.Text = directorySelector.SelectedPath;

                // Process matches & show them
                MatchedFileView.Text = FileHandling.GetMatchList(_directoryLocation, new Patterns() { Directory = DirectoryPatternBox.Text, File = FilePatternBox.Text}).Join(Environment.NewLine);
            }
        }

        private void CleanSourceButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to continue with the deletion of all the marked files? (Yes/No)", "Confirm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                FileHandling.DeleteSubFolders(_directoryLocation, new Patterns() { Directory = DirectoryPatternBox.Text, File = FilePatternBox.Text});
                MessageBox.Show("Your Source Tree is now cleaned.");
            }
        }

        private void RefreshMatchesButton_Click(object sender, EventArgs e)
        {
            MatchedFileView.Text = FileHandling.GetMatchList(_directoryLocation, new Patterns() { Directory = DirectoryPatternBox.Text, File = FilePatternBox.Text }).Join(Environment.NewLine);
        }
    }
}
