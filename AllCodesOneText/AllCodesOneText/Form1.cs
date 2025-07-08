using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AllCodesOneText
{
    public partial class formMain : Form
    {

        private bool isHandlingCheckChange = false;
        public formMain()
        {
            InitializeComponent();
            SetFormDeign();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = dialog.SelectedPath;
                txtSelectedFolderPath.Text = selectedPath;
            }

            SetComboBoxExtensions();
        }

        private void checkBoxAddAllSubFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (isHandlingCheckChange) return;

            isHandlingCheckChange = true;

            if (checkBoxAddAllSubFolder.Checked)
                checkBoxOnlySelectedFolder.Checked = false;

            string selectedPath = txtSelectedFolderPath?.Text;

            if (string.IsNullOrWhiteSpace(selectedPath))
            {
                checkBoxAddAllSubFolder.Checked = false;
                MessageBox.Show("Select input folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isHandlingCheckChange = false;
                return;
            }

            if (Directory.Exists(selectedPath))
            {
                List<string> extensions = GetAllFileExtensions(selectedPath);
                txtExtensions.Text = string.Join(Environment.NewLine, extensions);
            }
            else
            {
                txtExtensions.Clear();
            }

            isHandlingCheckChange = false;
        }

        private void checkBoxOnlySelectedFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (isHandlingCheckChange) return;

            isHandlingCheckChange = true;

            if (checkBoxOnlySelectedFolder.Checked)
                checkBoxAddAllSubFolder.Checked = false;

            string selectedPath = txtSelectedFolderPath.Text;

            if (string.IsNullOrWhiteSpace(selectedPath))
            {
                checkBoxOnlySelectedFolder.Checked = false;
                MessageBox.Show("Select input folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isHandlingCheckChange = false;
                return;
            }

            if (Directory.Exists(selectedPath))
            {
                List<string> extensions = GetFileExtensionsOnlyInRootFolder(selectedPath);
                txtExtensions.Text = string.Join(Environment.NewLine, extensions);
            }
            else
            {
                txtExtensions.Clear();
            }

            isHandlingCheckChange = false;
        }

        private void buttonAddExtension_Click(object sender, EventArgs e)
        {
            string extension = comboBoxExtansions.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(extension))
            {
                MessageBox.Show("Choose a extension", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtExtensions.Text.Contains(extension))
            {
                MessageBox.Show("Already Chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtExtensions.AppendText(Environment.NewLine + extension);
        }

        private void buttonSelectOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = dialog.SelectedPath;
                txtOutput.Text = selectedPath;
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            string selectedFolder = txtSelectedFolderPath.Text;
            string outputFolder = txtOutput.Text;
            string fileName = txtSavedFileName.Text.Trim();

            List<string> allowedExtensions = txtExtensions.Lines
                .Select(ext => ext.Trim().ToLower())
                .Where(ext => !string.IsNullOrWhiteSpace(ext))
                .ToList();

            if (!Directory.Exists(selectedFolder))
            {
                MessageBox.Show("Select input folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(outputFolder))
            {
                MessageBox.Show("Select output folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Enter a file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string savePath = Path.Combine(outputFolder, fileName + ".txt");

 
            if (File.Exists(savePath))
            {
                DialogResult result = MessageBox.Show(
                    $"File '{fileName}.txt' already exists in the output folder. Overwrite?",
                    "File Exists",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            bool includeSubFolders = checkBoxMergeAllSubFolder.Checked;

            var files = Directory.GetFiles(
                selectedFolder,
                "*.*",
                includeSubFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly
            ).Where(file => allowedExtensions.Contains(Path.GetExtension(file).ToLower())).ToList();

            if (files.Count == 0)
            {
                MessageBox.Show("No files found with selected extensions.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(savePath, false))
                {
                    foreach (string file in files)
                    {
                        writer.WriteLine($"----- {Path.GetFileName(file)} -----");
                        writer.WriteLine(File.ReadAllText(file));
                        writer.WriteLine(); 
                    }
                }

                MessageBox.Show("Files merged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetFormDeign()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = true;
        }

        public List<string> GetAllFileExtensions(string rootFolder)
        {
            HashSet<string> foundExtensions = new HashSet<string>();

            try
            {
                string[] allFiles = Directory.GetFiles(rootFolder, "*.*", SearchOption.AllDirectories);
                foreach (string file in allFiles)
                {
                    string ext = Path.GetExtension(file).ToLower();
                    if (!string.IsNullOrWhiteSpace(ext))
                        foundExtensions.Add(ext);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return foundExtensions.OrderBy(e => e).ToList();
        }

        public static List<string> GetFileExtensionsOnlyInRootFolder(string rootFolder)
        {
            HashSet<string> foundExtensions = new HashSet<string>();

            try
            {
                string[] files = Directory.GetFiles(rootFolder, "*.*", SearchOption.TopDirectoryOnly);
                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file).ToLower();
                    if (!string.IsNullOrWhiteSpace(ext))
                        foundExtensions.Add(ext);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return foundExtensions.OrderBy(e => e).ToList();
        }

        private void SetComboBoxExtensions()
        {
            string selectedPath = txtSelectedFolderPath.Text;
            comboBoxExtansions.Items.Clear();

            if (Directory.Exists(selectedPath))
            {
                List<string> extensions = GetAllFileExtensions(selectedPath);
                foreach (var extension in extensions)
                    comboBoxExtansions.Items.Add(extension);
            }
        }
    }
}
