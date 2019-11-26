namespace HydrometTools.Reports
{
    partial class OpsLog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogEntry = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSaveEntry = new System.Windows.Forms.Button();
            this.buttonRefreshLog = new System.Windows.Forms.Button();
            this.dateTimePickerT1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerT2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBasin = new System.Windows.Forms.ComboBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.checkBoxFilterLogEntries = new System.Windows.Forms.CheckBox();
            this.buttonExportLogs = new System.Windows.Forms.Button();
            this.buttonAttachFile = new System.Windows.Forms.Button();
            this.labelAttachmentPath = new System.Windows.Forms.Label();
            this.labelAttachmentName = new System.Windows.Forms.Label();
            this.labelAttachmentSize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxColumns = new System.Windows.Forms.ComboBox();
            this.checkBoxLogSearch = new System.Windows.Forms.CheckBox();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(4, 4);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 17);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log Entry: ";
            // 
            // textBoxLogEntry
            // 
            this.textBoxLogEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogEntry.Location = new System.Drawing.Point(88, 33);
            this.textBoxLogEntry.Multiline = true;
            this.textBoxLogEntry.Name = "textBoxLogEntry";
            this.textBoxLogEntry.Size = new System.Drawing.Size(760, 70);
            this.textBoxLogEntry.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 469);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonSaveEntry
            // 
            this.buttonSaveEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEntry.ForeColor = System.Drawing.Color.Blue;
            this.buttonSaveEntry.Location = new System.Drawing.Point(855, 33);
            this.buttonSaveEntry.Name = "buttonSaveEntry";
            this.buttonSaveEntry.Size = new System.Drawing.Size(98, 46);
            this.buttonSaveEntry.TabIndex = 4;
            this.buttonSaveEntry.Text = "Save Log Entry";
            this.buttonSaveEntry.UseVisualStyleBackColor = true;
            this.buttonSaveEntry.Click += new System.EventHandler(this.buttonSaveEntry_Click);
            // 
            // buttonRefreshLog
            // 
            this.buttonRefreshLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshLog.Location = new System.Drawing.Point(855, 614);
            this.buttonRefreshLog.Name = "buttonRefreshLog";
            this.buttonRefreshLog.Size = new System.Drawing.Size(98, 52);
            this.buttonRefreshLog.TabIndex = 5;
            this.buttonRefreshLog.Text = "Refresh Log";
            this.buttonRefreshLog.UseVisualStyleBackColor = true;
            this.buttonRefreshLog.Click += new System.EventHandler(this.buttonRefreshLog_Click);
            // 
            // dateTimePickerT1
            // 
            this.dateTimePickerT1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerT1.CustomFormat = "ddd, MMM-d-yyyy HH:mm";
            this.dateTimePickerT1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerT1.Location = new System.Drawing.Point(624, 614);
            this.dateTimePickerT1.Name = "dateTimePickerT1";
            this.dateTimePickerT1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePickerT1.TabIndex = 6;
            // 
            // dateTimePickerT2
            // 
            this.dateTimePickerT2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerT2.CustomFormat = "ddd, MMM-d-yyyy HH:mm";
            this.dateTimePickerT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerT2.Location = new System.Drawing.Point(624, 644);
            this.dateTimePickerT2.Name = "dateTimePickerT2";
            this.dateTimePickerT2.Size = new System.Drawing.Size(224, 22);
            this.dateTimePickerT2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start Date: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "End Date: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Basin: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Project: ";
            // 
            // comboBoxBasin
            // 
            this.comboBoxBasin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBasin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBasin.FormattingEnabled = true;
            this.comboBoxBasin.Location = new System.Drawing.Point(476, 1);
            this.comboBoxBasin.Name = "comboBoxBasin";
            this.comboBoxBasin.Size = new System.Drawing.Size(179, 24);
            this.comboBoxBasin.TabIndex = 14;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(727, 1);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(226, 24);
            this.comboBoxProject.TabIndex = 15;
            // 
            // checkBoxFilterLogEntries
            // 
            this.checkBoxFilterLogEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxFilterLogEntries.AutoSize = true;
            this.checkBoxFilterLogEntries.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFilterLogEntries.Name = "checkBoxFilterLogEntries";
            this.checkBoxFilterLogEntries.Size = new System.Drawing.Size(250, 21);
            this.checkBoxFilterLogEntries.TabIndex = 16;
            this.checkBoxFilterLogEntries.Text = "Filter log entries by Basin && Project";
            this.checkBoxFilterLogEntries.UseVisualStyleBackColor = true;
            // 
            // buttonExportLogs
            // 
            this.buttonExportLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportLogs.Location = new System.Drawing.Point(855, 672);
            this.buttonExportLogs.Name = "buttonExportLogs";
            this.buttonExportLogs.Size = new System.Drawing.Size(98, 25);
            this.buttonExportLogs.TabIndex = 17;
            this.buttonExportLogs.Text = "Export Log";
            this.buttonExportLogs.UseVisualStyleBackColor = true;
            this.buttonExportLogs.Click += new System.EventHandler(this.buttonExportLogs_Click);
            // 
            // buttonAttachFile
            // 
            this.buttonAttachFile.Location = new System.Drawing.Point(88, 109);
            this.buttonAttachFile.Name = "buttonAttachFile";
            this.buttonAttachFile.Size = new System.Drawing.Size(122, 24);
            this.buttonAttachFile.TabIndex = 18;
            this.buttonAttachFile.Text = "Attach File";
            this.buttonAttachFile.UseVisualStyleBackColor = true;
            this.buttonAttachFile.Click += new System.EventHandler(this.buttonAttachFile_Click);
            // 
            // labelAttachmentPath
            // 
            this.labelAttachmentPath.AutoSize = true;
            this.labelAttachmentPath.Location = new System.Drawing.Point(217, 112);
            this.labelAttachmentPath.Name = "labelAttachmentPath";
            this.labelAttachmentPath.Size = new System.Drawing.Size(124, 17);
            this.labelAttachmentPath.TabIndex = 19;
            this.labelAttachmentPath.Text = "Attachment Path...";
            this.labelAttachmentPath.Visible = false;
            // 
            // labelAttachmentName
            // 
            this.labelAttachmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAttachmentName.AutoSize = true;
            this.labelAttachmentName.Location = new System.Drawing.Point(664, 112);
            this.labelAttachmentName.Name = "labelAttachmentName";
            this.labelAttachmentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAttachmentName.Size = new System.Drawing.Size(146, 17);
            this.labelAttachmentName.TabIndex = 20;
            this.labelAttachmentName.Text = "labelAttachmentName";
            this.labelAttachmentName.Visible = false;
            // 
            // labelAttachmentSize
            // 
            this.labelAttachmentSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAttachmentSize.AutoSize = true;
            this.labelAttachmentSize.Location = new System.Drawing.Point(817, 112);
            this.labelAttachmentSize.Name = "labelAttachmentSize";
            this.labelAttachmentSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAttachmentSize.Size = new System.Drawing.Size(136, 17);
            this.labelAttachmentSize.TabIndex = 21;
            this.labelAttachmentSize.Text = "labelAttachmentSize";
            this.labelAttachmentSize.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxKeyword);
            this.groupBox1.Controls.Add(this.checkBoxLogSearch);
            this.groupBox1.Controls.Add(this.comboBoxColumns);
            this.groupBox1.Controls.Add(this.checkBoxFilterLogEntries);
            this.groupBox1.Location = new System.Drawing.Point(7, 614);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 85);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Filter";
            // 
            // comboBoxColumns
            // 
            this.comboBoxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumns.Enabled = false;
            this.comboBoxColumns.FormattingEnabled = true;
            this.comboBoxColumns.Location = new System.Drawing.Point(387, 46);
            this.comboBoxColumns.Name = "comboBoxColumns";
            this.comboBoxColumns.Size = new System.Drawing.Size(137, 24);
            this.comboBoxColumns.TabIndex = 23;
            // 
            // checkBoxLogSearch
            // 
            this.checkBoxLogSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxLogSearch.AutoSize = true;
            this.checkBoxLogSearch.Location = new System.Drawing.Point(6, 50);
            this.checkBoxLogSearch.Name = "checkBoxLogSearch";
            this.checkBoxLogSearch.Size = new System.Drawing.Size(139, 21);
            this.checkBoxLogSearch.TabIndex = 24;
            this.checkBoxLogSearch.Text = "Keyword search: ";
            this.checkBoxLogSearch.UseVisualStyleBackColor = true;
            this.checkBoxLogSearch.CheckedChanged += new System.EventHandler(this.checkBoxLogSearch_CheckedChanged);
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Enabled = false;
            this.textBoxKeyword.Location = new System.Drawing.Point(151, 46);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(128, 22);
            this.textBoxKeyword.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "in the column ";
            // 
            // OpsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAttachmentSize);
            this.Controls.Add(this.labelAttachmentName);
            this.Controls.Add(this.labelAttachmentPath);
            this.Controls.Add(this.buttonAttachFile);
            this.Controls.Add(this.buttonExportLogs);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.comboBoxBasin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerT2);
            this.Controls.Add(this.dateTimePickerT1);
            this.Controls.Add(this.buttonRefreshLog);
            this.Controls.Add(this.buttonSaveEntry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxLogEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUser);
            this.Name = "OpsLog";
            this.Size = new System.Drawing.Size(956, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogEntry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSaveEntry;
        private System.Windows.Forms.Button buttonRefreshLog;
        private System.Windows.Forms.DateTimePicker dateTimePickerT1;
        private System.Windows.Forms.DateTimePicker dateTimePickerT2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBasin;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.CheckBox checkBoxFilterLogEntries;
        private System.Windows.Forms.Button buttonExportLogs;
        private System.Windows.Forms.Button buttonAttachFile;
        private System.Windows.Forms.Label labelAttachmentPath;
        private System.Windows.Forms.Label labelAttachmentName;
        private System.Windows.Forms.Label labelAttachmentSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.CheckBox checkBoxLogSearch;
        private System.Windows.Forms.ComboBox comboBoxColumns;
    }
}
