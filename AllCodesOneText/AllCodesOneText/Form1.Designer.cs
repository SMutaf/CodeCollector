using System.Windows.Forms;

namespace AllCodesOneText
{
    partial class formMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelSelectedFolderPath = new Label();
            txtSelectedFolderPath = new TextBox();
            buttonSelectFolder = new Button();
            panelExtensions = new Panel();
            label1 = new Label();
            panelManuelExtensions = new Panel();
            label3 = new Label();
            buttonAddExtension = new Button();
            comboBoxExtansions = new ComboBox();
            panelAutoExtensions = new Panel();
            label4 = new Label();
            checkBoxOnlySelectedFolder = new CheckBox();
            checkBoxAddAllSubFolder = new CheckBox();
            txtExtensions = new TextBox();
            labelExtensions = new Label();
            panelOutput = new Panel();
            txtSavedFileName = new TextBox();
            labelMergedFileName = new Label();
            buttonSelectOutput = new Button();
            txtOutput = new TextBox();
            labelOutput = new Label();
            buttonMerge = new Button();
            checkBoxMergeAllSubFolder = new CheckBox();
            label2 = new Label();
            panelMerge = new Panel();
            panel1.SuspendLayout();
            panelExtensions.SuspendLayout();
            panelManuelExtensions.SuspendLayout();
            panelAutoExtensions.SuspendLayout();
            panelOutput.SuspendLayout();
            panelMerge.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelSelectedFolderPath);
            panel1.Controls.Add(txtSelectedFolderPath);
            panel1.Controls.Add(buttonSelectFolder);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 100);
            panel1.TabIndex = 0;
            // 
            // labelSelectedFolderPath
            // 
            labelSelectedFolderPath.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelSelectedFolderPath.Location = new Point(10, 10);
            labelSelectedFolderPath.Name = "labelSelectedFolderPath";
            labelSelectedFolderPath.Size = new Size(200, 20);
            labelSelectedFolderPath.TabIndex = 0;
            labelSelectedFolderPath.Text = "Selected Folder Path";
            // 
            // txtSelectedFolderPath
            // 
            txtSelectedFolderPath.Location = new Point(10, 35);
            txtSelectedFolderPath.Name = "txtSelectedFolderPath";
            txtSelectedFolderPath.Size = new Size(440, 23);
            txtSelectedFolderPath.TabIndex = 1;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.BackColor = SystemColors.ControlLightLight;
            buttonSelectFolder.Location = new Point(320, 65);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new Size(119, 23);
            buttonSelectFolder.TabIndex = 2;
            buttonSelectFolder.Text = "Select Folder";
            buttonSelectFolder.UseVisualStyleBackColor = false;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // panelExtensions
            // 
            panelExtensions.BorderStyle = BorderStyle.FixedSingle;
            panelExtensions.Controls.Add(label1);
            panelExtensions.Controls.Add(panelManuelExtensions);
            panelExtensions.Controls.Add(panelAutoExtensions);
            panelExtensions.Controls.Add(txtExtensions);
            panelExtensions.Controls.Add(labelExtensions);
            panelExtensions.Location = new Point(10, 120);
            panelExtensions.Name = "panelExtensions";
            panelExtensions.Size = new Size(460, 200);
            panelExtensions.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 163);
            label1.Name = "label1";
            label1.Size = new Size(436, 30);
            label1.TabIndex = 3;
            label1.Text = "The Include option includes extensions from the root folder and all subfolders.\r\nOnly Selected option will only display the extensions of files in the selected folder.\r\n";
            // 
            // panelManuelExtensions
            // 
            panelManuelExtensions.BorderStyle = BorderStyle.FixedSingle;
            panelManuelExtensions.Controls.Add(label3);
            panelManuelExtensions.Controls.Add(buttonAddExtension);
            panelManuelExtensions.Controls.Add(comboBoxExtansions);
            panelManuelExtensions.Location = new Point(246, 60);
            panelManuelExtensions.Name = "panelManuelExtensions";
            panelManuelExtensions.Size = new Size(204, 100);
            panelManuelExtensions.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(20, 13);
            label3.Name = "label3";
            label3.Size = new Size(163, 17);
            label3.TabIndex = 2;
            label3.Text = "Add extensions manually.";
            // 
            // buttonAddExtension
            // 
            buttonAddExtension.BackColor = SystemColors.ControlLightLight;
            buttonAddExtension.Location = new Point(131, 41);
            buttonAddExtension.Name = "buttonAddExtension";
            buttonAddExtension.Size = new Size(68, 23);
            buttonAddExtension.TabIndex = 0;
            buttonAddExtension.Text = "Add";
            buttonAddExtension.UseVisualStyleBackColor = false;
            buttonAddExtension.Click += buttonAddExtension_Click;
            // 
            // comboBoxExtansions
            // 
            comboBoxExtansions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExtansions.Location = new Point(3, 41);
            comboBoxExtansions.Name = "comboBoxExtansions";
            comboBoxExtansions.Size = new Size(128, 23);
            comboBoxExtansions.TabIndex = 1;
            // 
            // panelAutoExtensions
            // 
            panelAutoExtensions.BorderStyle = BorderStyle.FixedSingle;
            panelAutoExtensions.Controls.Add(label4);
            panelAutoExtensions.Controls.Add(checkBoxOnlySelectedFolder);
            panelAutoExtensions.Controls.Add(checkBoxAddAllSubFolder);
            panelAutoExtensions.Location = new Point(10, 60);
            panelAutoExtensions.Name = "panelAutoExtensions";
            panelAutoExtensions.Size = new Size(230, 100);
            panelAutoExtensions.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(20, 13);
            label4.Name = "label4";
            label4.Size = new Size(189, 17);
            label4.TabIndex = 3;
            label4.Text = "Add extensions automatically.";
            // 
            // checkBoxOnlySelectedFolder
            // 
            checkBoxOnlySelectedFolder.Location = new Point(10, 71);
            checkBoxOnlySelectedFolder.Name = "checkBoxOnlySelectedFolder";
            checkBoxOnlySelectedFolder.Size = new Size(104, 24);
            checkBoxOnlySelectedFolder.TabIndex = 0;
            checkBoxOnlySelectedFolder.Text = "Only selected folder";
            checkBoxOnlySelectedFolder.CheckedChanged += checkBoxOnlySelectedFolder_CheckedChanged;
            // 
            // checkBoxAddAllSubFolder
            // 
            checkBoxAddAllSubFolder.Location = new Point(10, 35);
            checkBoxAddAllSubFolder.Name = "checkBoxAddAllSubFolder";
            checkBoxAddAllSubFolder.Size = new Size(131, 35);
            checkBoxAddAllSubFolder.TabIndex = 1;
            checkBoxAddAllSubFolder.Text = "Include subfolders";
            checkBoxAddAllSubFolder.CheckedChanged += checkBoxAddAllSubFolder_CheckedChanged;
            // 
            // txtExtensions
            // 
            txtExtensions.Location = new Point(10, 30);
            txtExtensions.Name = "txtExtensions";
            txtExtensions.Size = new Size(440, 23);
            txtExtensions.TabIndex = 2;
            // 
            // labelExtensions
            // 
            labelExtensions.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelExtensions.Location = new Point(10, 5);
            labelExtensions.Name = "labelExtensions";
            labelExtensions.Size = new Size(250, 36);
            labelExtensions.TabIndex = 3;
            labelExtensions.Text = "File Extensions To Merge";
            // 
            // panelOutput
            // 
            panelOutput.BorderStyle = BorderStyle.FixedSingle;
            panelOutput.Controls.Add(txtSavedFileName);
            panelOutput.Controls.Add(labelMergedFileName);
            panelOutput.Controls.Add(buttonSelectOutput);
            panelOutput.Controls.Add(txtOutput);
            panelOutput.Controls.Add(labelOutput);
            panelOutput.Location = new Point(10, 330);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(460, 133);
            panelOutput.TabIndex = 2;
            // 
            // txtSavedFileName
            // 
            txtSavedFileName.Location = new Point(10, 98);
            txtSavedFileName.Name = "txtSavedFileName";
            txtSavedFileName.Size = new Size(200, 23);
            txtSavedFileName.TabIndex = 0;
            // 
            // labelMergedFileName
            // 
            labelMergedFileName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelMergedFileName.Location = new Point(10, 72);
            labelMergedFileName.Name = "labelMergedFileName";
            labelMergedFileName.Size = new Size(123, 23);
            labelMergedFileName.TabIndex = 1;
            labelMergedFileName.Text = "Output File Name";
            // 
            // buttonSelectOutput
            // 
            buttonSelectOutput.BackColor = SystemColors.ControlLightLight;
            buttonSelectOutput.Location = new Point(320, 70);
            buttonSelectOutput.Name = "buttonSelectOutput";
            buttonSelectOutput.Size = new Size(119, 23);
            buttonSelectOutput.TabIndex = 2;
            buttonSelectOutput.Text = "Select Output Folder";
            buttonSelectOutput.UseVisualStyleBackColor = false;
            buttonSelectOutput.Click += buttonSelectOutput_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(10, 35);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(440, 23);
            txtOutput.TabIndex = 3;
            // 
            // labelOutput
            // 
            labelOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelOutput.Location = new Point(10, 9);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(100, 23);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "Output Folder";
            // 
            // buttonMerge
            // 
            buttonMerge.BackColor = SystemColors.ControlLightLight;
            buttonMerge.Location = new Point(111, 9);
            buttonMerge.Name = "buttonMerge";
            buttonMerge.Size = new Size(75, 23);
            buttonMerge.TabIndex = 3;
            buttonMerge.Text = "Merge Files";
            buttonMerge.UseVisualStyleBackColor = false;
            buttonMerge.Click += buttonMerge_Click;
            // 
            // checkBoxMergeAllSubFolder
            // 
            checkBoxMergeAllSubFolder.Location = new Point(8, 3);
            checkBoxMergeAllSubFolder.Name = "checkBoxMergeAllSubFolder";
            checkBoxMergeAllSubFolder.Size = new Size(98, 36);
            checkBoxMergeAllSubFolder.TabIndex = 5;
            checkBoxMergeAllSubFolder.Text = "Include subfolders";
            // 
            // label2
            // 
            label2.Location = new Point(23, 466);
            label2.Name = "label2";
            label2.Size = new Size(241, 41);
            label2.TabIndex = 6;
            label2.Text = "Include files from subfolders. If unchecked, only current folder is used.";
            // 
            // panelMerge
            // 
            panelMerge.BorderStyle = BorderStyle.FixedSingle;
            panelMerge.Controls.Add(checkBoxMergeAllSubFolder);
            panelMerge.Controls.Add(buttonMerge);
            panelMerge.Location = new Point(270, 466);
            panelMerge.Name = "panelMerge";
            panelMerge.Size = new Size(200, 41);
            panelMerge.TabIndex = 7;
            // 
            // formMain
            // 
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(480, 511);
            Controls.Add(panelMerge);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panelExtensions);
            Controls.Add(panelOutput);
            Name = "formMain";
            Text = "Code Collector";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelExtensions.ResumeLayout(false);
            panelExtensions.PerformLayout();
            panelManuelExtensions.ResumeLayout(false);
            panelManuelExtensions.PerformLayout();
            panelAutoExtensions.ResumeLayout(false);
            panelAutoExtensions.PerformLayout();
            panelOutput.ResumeLayout(false);
            panelOutput.PerformLayout();
            panelMerge.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelSelectedFolderPath;
        private TextBox txtSelectedFolderPath;
        private Button buttonSelectFolder;
        private Panel panelExtensions;
        private Label labelExtensions;
        private TextBox txtExtensions;
        private Panel panelManuelExtensions;
        private ComboBox comboBoxExtansions;
        private Button buttonAddExtension;
        private Panel panelAutoExtensions;
        private CheckBox checkBoxOnlySelectedFolder;
        private CheckBox checkBoxAddAllSubFolder;
        private Panel panelOutput;
        private Label labelOutput;
        private TextBox txtOutput;
        private Button buttonSelectOutput;
        private TextBox txtSavedFileName;
        private Label labelMergedFileName;
        private Button buttonMerge;
        private CheckBox checkBoxMergeAllSubFolder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelMerge;
    }
}