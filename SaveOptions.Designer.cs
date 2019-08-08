namespace HydrometTools
{
    partial class SaveOptions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveOptions));
            this.checkBoxSaveVMS = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDependencies = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSaveVMS
            // 
            this.checkBoxSaveVMS.AutoSize = true;
            this.checkBoxSaveVMS.Checked = true;
            this.checkBoxSaveVMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveVMS.Location = new System.Drawing.Point(36, 113);
            this.checkBoxSaveVMS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSaveVMS.Name = "checkBoxSaveVMS";
            this.checkBoxSaveVMS.Size = new System.Drawing.Size(113, 21);
            this.checkBoxSaveVMS.TabIndex = 0;
            this.checkBoxSaveVMS.Text = "save to vms?";
            this.checkBoxSaveVMS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDependencies);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(241, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pisces database options";
            // 
            // checkBoxDependencies
            // 
            this.checkBoxDependencies.AutoSize = true;
            this.checkBoxDependencies.Checked = true;
            this.checkBoxDependencies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDependencies.Location = new System.Drawing.Point(20, 23);
            this.checkBoxDependencies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDependencies.Name = "checkBoxDependencies";
            this.checkBoxDependencies.Size = new System.Drawing.Size(177, 21);
            this.checkBoxDependencies.TabIndex = 2;
            this.checkBoxDependencies.Text = "compute dependencies";
            this.checkBoxDependencies.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(316, 145);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(316, 106);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // SaveOptions
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(432, 196);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxSaveVMS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SaveOptions";
            this.Text = "Save Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSaveVMS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDependencies;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}