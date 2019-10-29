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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSaveEntry = new System.Windows.Forms.Button();
            this.buttonRefreshLog = new System.Windows.Forms.Button();
            this.dateTimePickerT1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerT2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(88, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(760, 70);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 526);
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
            // 
            // buttonRefreshLog
            // 
            this.buttonRefreshLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshLog.Location = new System.Drawing.Point(855, 641);
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
            this.dateTimePickerT1.Location = new System.Drawing.Point(648, 641);
            this.dateTimePickerT1.Name = "dateTimePickerT1";
            this.dateTimePickerT1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerT1.TabIndex = 6;
            // 
            // dateTimePickerT2
            // 
            this.dateTimePickerT2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerT2.CustomFormat = "ddd, MMM-d-yyyy HH:mm";
            this.dateTimePickerT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerT2.Location = new System.Drawing.Point(648, 671);
            this.dateTimePickerT2.Name = "dateTimePickerT2";
            this.dateTimePickerT2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerT2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start Date: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "End Date: ";
            // 
            // OpsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerT2);
            this.Controls.Add(this.dateTimePickerT1);
            this.Controls.Add(this.buttonRefreshLog);
            this.Controls.Add(this.buttonSaveEntry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUser);
            this.Name = "OpsLog";
            this.Size = new System.Drawing.Size(956, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSaveEntry;
        private System.Windows.Forms.Button buttonRefreshLog;
        private System.Windows.Forms.DateTimePicker dateTimePickerT1;
        private System.Windows.Forms.DateTimePicker dateTimePickerT2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
