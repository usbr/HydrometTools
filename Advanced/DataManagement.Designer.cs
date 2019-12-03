namespace HydrometTools.Advanced
{
    partial class DataManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTInterval = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dateTimePickerT1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerT2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPCodes = new System.Windows.Forms.TextBox();
            this.textBoxSites = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerT2);
            this.groupBox1.Controls.Add(this.dateTimePickerT1);
            this.groupBox1.Controls.Add(this.buttonCalculate);
            this.groupBox1.Controls.Add(this.comboBoxTInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSites);
            this.groupBox1.Controls.Add(this.textBoxPCodes);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site Code(s):  (comma-delimited)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time Interval: ";
            // 
            // comboBoxTInterval
            // 
            this.comboBoxTInterval.FormattingEnabled = true;
            this.comboBoxTInterval.Location = new System.Drawing.Point(122, 164);
            this.comboBoxTInterval.Name = "comboBoxTInterval";
            this.comboBoxTInterval.Size = new System.Drawing.Size(166, 24);
            this.comboBoxTInterval.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(199, 257);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(95, 39);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // dateTimePickerT1
            // 
            this.dateTimePickerT1.Checked = false;
            this.dateTimePickerT1.CustomFormat = "";
            this.dateTimePickerT1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerT1.Location = new System.Drawing.Point(122, 198);
            this.dateTimePickerT1.Name = "dateTimePickerT1";
            this.dateTimePickerT1.Size = new System.Drawing.Size(166, 22);
            this.dateTimePickerT1.TabIndex = 8;
            // 
            // dateTimePickerT2
            // 
            this.dateTimePickerT2.Checked = false;
            this.dateTimePickerT2.CustomFormat = "";
            this.dateTimePickerT2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerT2.Location = new System.Drawing.Point(122, 226);
            this.dateTimePickerT2.Name = "dateTimePickerT2";
            this.dateTimePickerT2.Size = new System.Drawing.Size(166, 22);
            this.dateTimePickerT2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Date: ";
            // 
            // textBoxPCodes
            // 
            this.textBoxPCodes.Location = new System.Drawing.Point(39, 126);
            this.textBoxPCodes.Name = "textBoxPCodes";
            this.textBoxPCodes.Size = new System.Drawing.Size(249, 22);
            this.textBoxPCodes.TabIndex = 1;
            // 
            // textBoxSites
            // 
            this.textBoxSites.Location = new System.Drawing.Point(39, 63);
            this.textBoxSites.Name = "textBoxSites";
            this.textBoxSites.Size = new System.Drawing.Size(249, 22);
            this.textBoxSites.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "P-Code(s):  (comma-delimited)";
            // 
            // DataManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "DataManagement";
            this.Size = new System.Drawing.Size(823, 719);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ComboBox comboBoxTInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerT2;
        private System.Windows.Forms.DateTimePicker dateTimePickerT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSites;
        private System.Windows.Forms.TextBox textBoxPCodes;
    }
}
