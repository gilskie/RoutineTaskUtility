namespace RoutineTaskUtility
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            reportToolStripMenuItem = new ToolStripMenuItem();
            dSTReportToolStripMenuItem = new ToolStripMenuItem();
            rejectedReportToolStripMenuItem = new ToolStripMenuItem();
            manualRelayReportToolStripMenuItem = new ToolStripMenuItem();
            tCPerAgentReportToolStripMenuItem = new ToolStripMenuItem();
            pWAFToolStripMenuItem = new ToolStripMenuItem();
            pWAFUploadToolStripMenuItem = new ToolStripMenuItem();
            pWAFEditToolStripMenuItem = new ToolStripMenuItem();
            databaseToolStripMenuItem = new ToolStripMenuItem();
            connectToDatabaseToolStripMenuItem = new ToolStripMenuItem();
            richTextBoxLogMessage = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            DBConnectionStatusLabel = new Label();
            ManualCreateFolderGroupBox = new GroupBox();
            TodateTimePicker = new DateTimePicker();
            label5 = new Label();
            FromdateTimePicker = new DateTimePicker();
            label4 = new Label();
            ReportGenerateCheckedListBox = new CheckedListBox();
            ReportToGenerateLabel = new Label();
            SBUCheckedListBox = new CheckedListBox();
            SBUlabel = new Label();
            CreateFoldersButton = new Button();
            selectedPathLabel = new Label();
            RootFolderSelectButton = new Button();
            menuStrip1.SuspendLayout();
            ManualCreateFolderGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reportToolStripMenuItem, pWAFToolStripMenuItem, databaseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dSTReportToolStripMenuItem, rejectedReportToolStripMenuItem, manualRelayReportToolStripMenuItem, tCPerAgentReportToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(68, 24);
            reportToolStripMenuItem.Text = "Report";
            // 
            // dSTReportToolStripMenuItem
            // 
            dSTReportToolStripMenuItem.Name = "dSTReportToolStripMenuItem";
            dSTReportToolStripMenuItem.Size = new Size(230, 26);
            dSTReportToolStripMenuItem.Text = "DST Report";
            dSTReportToolStripMenuItem.Click += dSTReportToolStripMenuItem_Click;
            // 
            // rejectedReportToolStripMenuItem
            // 
            rejectedReportToolStripMenuItem.Name = "rejectedReportToolStripMenuItem";
            rejectedReportToolStripMenuItem.Size = new Size(230, 26);
            rejectedReportToolStripMenuItem.Text = "Rejected Report";
            rejectedReportToolStripMenuItem.Click += rejectedReportToolStripMenuItem_Click;
            // 
            // manualRelayReportToolStripMenuItem
            // 
            manualRelayReportToolStripMenuItem.Name = "manualRelayReportToolStripMenuItem";
            manualRelayReportToolStripMenuItem.Size = new Size(230, 26);
            manualRelayReportToolStripMenuItem.Text = "Manual Relay Report";
            manualRelayReportToolStripMenuItem.Click += manualRelayReportToolStripMenuItem_Click;
            // 
            // tCPerAgentReportToolStripMenuItem
            // 
            tCPerAgentReportToolStripMenuItem.Name = "tCPerAgentReportToolStripMenuItem";
            tCPerAgentReportToolStripMenuItem.Size = new Size(230, 26);
            tCPerAgentReportToolStripMenuItem.Text = "TC Per Agent Report";
            tCPerAgentReportToolStripMenuItem.Click += tCPerAgentReportToolStripMenuItem_Click;
            // 
            // pWAFToolStripMenuItem
            // 
            pWAFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pWAFUploadToolStripMenuItem, pWAFEditToolStripMenuItem });
            pWAFToolStripMenuItem.Name = "pWAFToolStripMenuItem";
            pWAFToolStripMenuItem.Size = new Size(61, 24);
            pWAFToolStripMenuItem.Text = "PWAF";
            // 
            // pWAFUploadToolStripMenuItem
            // 
            pWAFUploadToolStripMenuItem.Name = "pWAFUploadToolStripMenuItem";
            pWAFUploadToolStripMenuItem.Size = new Size(183, 26);
            pWAFUploadToolStripMenuItem.Text = "PWAF Upload";
            pWAFUploadToolStripMenuItem.Click += pWAFUploadToolStripMenuItem_Click;
            // 
            // pWAFEditToolStripMenuItem
            // 
            pWAFEditToolStripMenuItem.Name = "pWAFEditToolStripMenuItem";
            pWAFEditToolStripMenuItem.Size = new Size(183, 26);
            pWAFEditToolStripMenuItem.Text = "PWAF Edit";
            pWAFEditToolStripMenuItem.Click += pWAFEditToolStripMenuItem_Click;
            // 
            // databaseToolStripMenuItem
            // 
            databaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToDatabaseToolStripMenuItem });
            databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            databaseToolStripMenuItem.Size = new Size(86, 24);
            databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToDatabaseToolStripMenuItem
            // 
            connectToDatabaseToolStripMenuItem.Name = "connectToDatabaseToolStripMenuItem";
            connectToDatabaseToolStripMenuItem.Size = new Size(229, 26);
            connectToDatabaseToolStripMenuItem.Text = "Connect to database";
            connectToDatabaseToolStripMenuItem.Click += connectToDatabaseToolStripMenuItem_Click;
            // 
            // richTextBoxLogMessage
            // 
            richTextBoxLogMessage.Location = new Point(55, 466);
            richTextBoxLogMessage.Name = "richTextBoxLogMessage";
            richTextBoxLogMessage.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxLogMessage.Size = new Size(716, 80);
            richTextBoxLogMessage.TabIndex = 2;
            richTextBoxLogMessage.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 443);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "Log Message:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 556);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 4;
            label2.Text = "DB Connection:";
            // 
            // DBConnectionStatusLabel
            // 
            DBConnectionStatusLabel.AutoSize = true;
            DBConnectionStatusLabel.Location = new Point(615, 556);
            DBConnectionStatusLabel.Name = "DBConnectionStatusLabel";
            DBConnectionStatusLabel.Size = new Size(65, 20);
            DBConnectionStatusLabel.TabIndex = 5;
            DBConnectionStatusLabel.Text = "Fetching";
            // 
            // ManualCreateFolderGroupBox
            // 
            ManualCreateFolderGroupBox.Controls.Add(TodateTimePicker);
            ManualCreateFolderGroupBox.Controls.Add(label5);
            ManualCreateFolderGroupBox.Controls.Add(FromdateTimePicker);
            ManualCreateFolderGroupBox.Controls.Add(label4);
            ManualCreateFolderGroupBox.Controls.Add(ReportGenerateCheckedListBox);
            ManualCreateFolderGroupBox.Controls.Add(ReportToGenerateLabel);
            ManualCreateFolderGroupBox.Controls.Add(SBUCheckedListBox);
            ManualCreateFolderGroupBox.Controls.Add(SBUlabel);
            ManualCreateFolderGroupBox.Controls.Add(CreateFoldersButton);
            ManualCreateFolderGroupBox.Controls.Add(selectedPathLabel);
            ManualCreateFolderGroupBox.Controls.Add(RootFolderSelectButton);
            ManualCreateFolderGroupBox.Location = new Point(49, 59);
            ManualCreateFolderGroupBox.Name = "ManualCreateFolderGroupBox";
            ManualCreateFolderGroupBox.Size = new Size(716, 368);
            ManualCreateFolderGroupBox.TabIndex = 6;
            ManualCreateFolderGroupBox.TabStop = false;
            ManualCreateFolderGroupBox.Text = "Manual Folder Create";
            // 
            // TodateTimePicker
            // 
            TodateTimePicker.Format = DateTimePickerFormat.Short;
            TodateTimePicker.Location = new Point(357, 281);
            TodateTimePicker.Name = "TodateTimePicker";
            TodateTimePicker.Size = new Size(162, 27);
            TodateTimePicker.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 284);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 9;
            label5.Text = "-";
            // 
            // FromdateTimePicker
            // 
            FromdateTimePicker.Format = DateTimePickerFormat.Short;
            FromdateTimePicker.Location = new Point(157, 281);
            FromdateTimePicker.Name = "FromdateTimePicker";
            FromdateTimePicker.Size = new Size(162, 27);
            FromdateTimePicker.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 281);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Date Range";
            // 
            // ReportGenerateCheckedListBox
            // 
            ReportGenerateCheckedListBox.FormattingEnabled = true;
            ReportGenerateCheckedListBox.Items.AddRange(new object[] { "DST Report", "Rejected Report", "Manual Relay Report", "TC Per Agent Report" });
            ReportGenerateCheckedListBox.Location = new Point(157, 155);
            ReportGenerateCheckedListBox.Name = "ReportGenerateCheckedListBox";
            ReportGenerateCheckedListBox.Size = new Size(283, 92);
            ReportGenerateCheckedListBox.TabIndex = 6;
            // 
            // ReportToGenerateLabel
            // 
            ReportToGenerateLabel.AutoSize = true;
            ReportToGenerateLabel.Location = new Point(6, 155);
            ReportToGenerateLabel.Name = "ReportToGenerateLabel";
            ReportToGenerateLabel.Size = new Size(138, 20);
            ReportToGenerateLabel.TabIndex = 5;
            ReportToGenerateLabel.Text = "Report To Generate";
            // 
            // SBUCheckedListBox
            // 
            SBUCheckedListBox.FormattingEnabled = true;
            SBUCheckedListBox.Items.AddRange(new object[] { "Jollibee", "Greenwich" });
            SBUCheckedListBox.Location = new Point(157, 80);
            SBUCheckedListBox.Name = "SBUCheckedListBox";
            SBUCheckedListBox.Size = new Size(109, 48);
            SBUCheckedListBox.TabIndex = 4;
            // 
            // SBUlabel
            // 
            SBUlabel.AutoSize = true;
            SBUlabel.Location = new Point(6, 80);
            SBUlabel.Name = "SBUlabel";
            SBUlabel.Size = new Size(115, 20);
            SBUlabel.TabIndex = 3;
            SBUlabel.Text = "Select SBU Type";
            // 
            // CreateFoldersButton
            // 
            CreateFoldersButton.Location = new Point(586, 333);
            CreateFoldersButton.Name = "CreateFoldersButton";
            CreateFoldersButton.Size = new Size(124, 29);
            CreateFoldersButton.TabIndex = 2;
            CreateFoldersButton.Text = "Create Folders";
            CreateFoldersButton.UseVisualStyleBackColor = true;
            CreateFoldersButton.Click += CreateFoldersButton_Click;
            // 
            // selectedPathLabel
            // 
            selectedPathLabel.AutoSize = true;
            selectedPathLabel.Location = new Point(157, 42);
            selectedPathLabel.Name = "selectedPathLabel";
            selectedPathLabel.Size = new Size(0, 20);
            selectedPathLabel.TabIndex = 1;
            // 
            // RootFolderSelectButton
            // 
            RootFolderSelectButton.Location = new Point(6, 38);
            RootFolderSelectButton.Name = "RootFolderSelectButton";
            RootFolderSelectButton.Size = new Size(136, 29);
            RootFolderSelectButton.TabIndex = 0;
            RootFolderSelectButton.Text = "Set Root Folder";
            RootFolderSelectButton.UseVisualStyleBackColor = true;
            RootFolderSelectButton.Click += RootFolderSelectButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(ManualCreateFolderGroupBox);
            Controls.Add(DBConnectionStatusLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBoxLogMessage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Routine Task";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ManualCreateFolderGroupBox.ResumeLayout(false);
            ManualCreateFolderGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem dSTReportToolStripMenuItem;
        private ToolStripMenuItem rejectedReportToolStripMenuItem;
        private ToolStripMenuItem manualRelayReportToolStripMenuItem;
        private ToolStripMenuItem tCPerAgentReportToolStripMenuItem;
        private ToolStripMenuItem pWAFToolStripMenuItem;
        private ToolStripMenuItem pWAFUploadToolStripMenuItem;
        private ToolStripMenuItem pWAFEditToolStripMenuItem;
        private RichTextBox richTextBoxLogMessage;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem connectToDatabaseToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label DBConnectionStatusLabel;
        private GroupBox ManualCreateFolderGroupBox;
        private Button CreateFoldersButton;
        private Label selectedPathLabel;
        private Button RootFolderSelectButton;
        private Label SBUlabel;
        private CheckedListBox ReportGenerateCheckedListBox;
        private Label ReportToGenerateLabel;
        private CheckedListBox SBUCheckedListBox;
        private DateTimePicker FromdateTimePicker;
        private Label label4;
        private Label label5;
        private DateTimePicker TodateTimePicker;
    }
}
