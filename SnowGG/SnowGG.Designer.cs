namespace HydrometTools.SnowGG
{
    partial class SnowGG
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
            this.components = new System.ComponentModel.Container();
            Reclamation.Core.MonthDayRange monthDayRange3 = new Reclamation.Core.MonthDayRange();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSumList = new System.Windows.Forms.CheckBox();
            this.buttonToggleMonths = new System.Windows.Forms.Button();
            this.checkBoxUseList = new System.Windows.Forms.CheckBox();
            this.textBoxMultiple = new System.Windows.Forms.TextBox();
            this.checkBoxDeltas = new System.Windows.Forms.CheckBox();
            this.checkBoxAnnotate = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPctls = new System.Windows.Forms.TextBox();
            this.checkBoxPctls = new System.Windows.Forms.CheckBox();
            this.textBoxWY2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWY1 = new System.Windows.Forms.TextBox();
            this.checkBoxAvg = new System.Windows.Forms.CheckBox();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.checkBoxGP = new System.Windows.Forms.CheckBox();
            this.checkBoxMpoll = new System.Windows.Forms.CheckBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSelectGroup = new System.Windows.Forms.Button();
            this.comboBoxCbtt = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxPcode = new System.Windows.Forms.ComboBox();
            this.monthRangePicker1 = new Reclamation.TimeSeries.Forms.MonthRangePicker();
            this.yearSelector1 = new Reclamation.TimeSeries.Forms.YearSelector();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxUseInstant = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxUseInstant);
            this.panel1.Controls.Add(this.checkBoxSumList);
            this.panel1.Controls.Add(this.buttonToggleMonths);
            this.panel1.Controls.Add(this.checkBoxUseList);
            this.panel1.Controls.Add(this.textBoxMultiple);
            this.panel1.Controls.Add(this.checkBoxDeltas);
            this.panel1.Controls.Add(this.checkBoxAnnotate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBoxGP);
            this.panel1.Controls.Add(this.checkBoxMpoll);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonSelectGroup);
            this.panel1.Controls.Add(this.comboBoxCbtt);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.comboBoxPcode);
            this.panel1.Controls.Add(this.monthRangePicker1);
            this.panel1.Controls.Add(this.yearSelector1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 198);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxSumList
            // 
            this.checkBoxSumList.AutoSize = true;
            this.checkBoxSumList.Enabled = false;
            this.checkBoxSumList.Location = new System.Drawing.Point(369, 139);
            this.checkBoxSumList.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxSumList.Name = "checkBoxSumList";
            this.checkBoxSumList.Size = new System.Drawing.Size(84, 21);
            this.checkBoxSumList.TabIndex = 18;
            this.checkBoxSumList.Text = "Sum List";
            this.checkBoxSumList.UseVisualStyleBackColor = true;
            // 
            // buttonToggleMonths
            // 
            this.buttonToggleMonths.Location = new System.Drawing.Point(993, 43);
            this.buttonToggleMonths.Name = "buttonToggleMonths";
            this.buttonToggleMonths.Size = new System.Drawing.Size(69, 39);
            this.buttonToggleMonths.TabIndex = 17;
            this.buttonToggleMonths.Text = "Use CY";
            this.buttonToggleMonths.UseVisualStyleBackColor = true;
            this.buttonToggleMonths.Click += new System.EventHandler(this.buttonToggleMonths_Click);
            // 
            // checkBoxUseList
            // 
            this.checkBoxUseList.AutoSize = true;
            this.checkBoxUseList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUseList.Location = new System.Drawing.Point(67, 84);
            this.checkBoxUseList.Name = "checkBoxUseList";
            this.checkBoxUseList.Size = new System.Drawing.Size(81, 21);
            this.checkBoxUseList.TabIndex = 16;
            this.checkBoxUseList.Text = "Use List";
            this.checkBoxUseList.UseVisualStyleBackColor = true;
            this.checkBoxUseList.CheckedChanged += new System.EventHandler(this.useList_CheckedChanged);
            // 
            // textBoxMultiple
            // 
            this.textBoxMultiple.Enabled = false;
            this.textBoxMultiple.Location = new System.Drawing.Point(154, 83);
            this.textBoxMultiple.Name = "textBoxMultiple";
            this.textBoxMultiple.Size = new System.Drawing.Size(301, 22);
            this.textBoxMultiple.TabIndex = 15;
            // 
            // checkBoxDeltas
            // 
            this.checkBoxDeltas.AutoSize = true;
            this.checkBoxDeltas.Location = new System.Drawing.Point(154, 140);
            this.checkBoxDeltas.Name = "checkBoxDeltas";
            this.checkBoxDeltas.Size = new System.Drawing.Size(182, 21);
            this.checkBoxDeltas.TabIndex = 14;
            this.checkBoxDeltas.Text = "Apply Deltas to 1st Year";
            this.checkBoxDeltas.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnnotate
            // 
            this.checkBoxAnnotate.AutoSize = true;
            this.checkBoxAnnotate.Checked = true;
            this.checkBoxAnnotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnnotate.Location = new System.Drawing.Point(154, 111);
            this.checkBoxAnnotate.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxAnnotate.Name = "checkBoxAnnotate";
            this.checkBoxAnnotate.Size = new System.Drawing.Size(138, 21);
            this.checkBoxAnnotate.TabIndex = 13;
            this.checkBoxAnnotate.Text = "date/value tooltip";
            this.checkBoxAnnotate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPctls);
            this.groupBox1.Controls.Add(this.checkBoxPctls);
            this.groupBox1.Controls.Add(this.textBoxWY2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxWY1);
            this.groupBox1.Controls.Add(this.checkBoxAvg);
            this.groupBox1.Controls.Add(this.checkBoxMax);
            this.groupBox1.Controls.Add(this.checkBoxMin);
            this.groupBox1.Location = new System.Drawing.Point(556, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(496, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Use";
            // 
            // textBoxPctls
            // 
            this.textBoxPctls.Location = new System.Drawing.Point(317, 50);
            this.textBoxPctls.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPctls.Name = "textBoxPctls";
            this.textBoxPctls.Size = new System.Drawing.Size(171, 22);
            this.textBoxPctls.TabIndex = 7;
            this.textBoxPctls.Text = "10, 50, 90";
            // 
            // checkBoxPctls
            // 
            this.checkBoxPctls.AutoSize = true;
            this.checkBoxPctls.Location = new System.Drawing.Point(207, 53);
            this.checkBoxPctls.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxPctls.Name = "checkBoxPctls";
            this.checkBoxPctls.Size = new System.Drawing.Size(100, 21);
            this.checkBoxPctls.TabIndex = 6;
            this.checkBoxPctls.Text = "Percentiles";
            this.checkBoxPctls.UseVisualStyleBackColor = true;
            // 
            // textBoxWY2
            // 
            this.textBoxWY2.Location = new System.Drawing.Point(139, 21);
            this.textBoxWY2.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWY2.Name = "textBoxWY2";
            this.textBoxWY2.Size = new System.Drawing.Size(54, 22);
            this.textBoxWY2.TabIndex = 5;
            this.textBoxWY2.Text = "2010";
            this.textBoxWY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // textBoxWY1
            // 
            this.textBoxWY1.Location = new System.Drawing.Point(49, 21);
            this.textBoxWY1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWY1.Name = "textBoxWY1";
            this.textBoxWY1.Size = new System.Drawing.Size(54, 22);
            this.textBoxWY1.TabIndex = 3;
            this.textBoxWY1.Text = "1981";
            this.textBoxWY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxAvg
            // 
            this.checkBoxAvg.AutoSize = true;
            this.checkBoxAvg.Location = new System.Drawing.Point(10, 52);
            this.checkBoxAvg.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxAvg.Name = "checkBoxAvg";
            this.checkBoxAvg.Size = new System.Drawing.Size(54, 21);
            this.checkBoxAvg.TabIndex = 2;
            this.checkBoxAvg.Text = "Avg";
            this.checkBoxAvg.UseVisualStyleBackColor = true;
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Location = new System.Drawing.Point(74, 52);
            this.checkBoxMax.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(55, 21);
            this.checkBoxMax.TabIndex = 1;
            this.checkBoxMax.Text = "Max";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Location = new System.Drawing.Point(145, 52);
            this.checkBoxMin.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(52, 21);
            this.checkBoxMin.TabIndex = 0;
            this.checkBoxMin.Text = "Min";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // checkBoxGP
            // 
            this.checkBoxGP.AutoSize = true;
            this.checkBoxGP.Location = new System.Drawing.Point(400, 169);
            this.checkBoxGP.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxGP.Name = "checkBoxGP";
            this.checkBoxGP.Size = new System.Drawing.Size(129, 21);
            this.checkBoxGP.TabIndex = 10;
            this.checkBoxGP.Text = "include  se_avg";
            this.checkBoxGP.UseVisualStyleBackColor = true;
            this.checkBoxGP.Visible = false;
            // 
            // checkBoxMpoll
            // 
            this.checkBoxMpoll.AutoSize = true;
            this.checkBoxMpoll.Location = new System.Drawing.Point(154, 169);
            this.checkBoxMpoll.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxMpoll.Name = "checkBoxMpoll";
            this.checkBoxMpoll.Size = new System.Drawing.Size(236, 21);
            this.checkBoxMpoll.TabIndex = 9;
            this.checkBoxMpoll.Text = "include monthly 30 year average";
            this.checkBoxMpoll.UseVisualStyleBackColor = true;
            this.checkBoxMpoll.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(465, 15);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(79, 24);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = ">";
            this.toolTip1.SetToolTip(this.buttonNext, "advance to next site");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSelectGroup
            // 
            this.buttonSelectGroup.AutoEllipsis = true;
            this.buttonSelectGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectGroup.Location = new System.Drawing.Point(9, 16);
            this.buttonSelectGroup.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSelectGroup.Name = "buttonSelectGroup";
            this.buttonSelectGroup.Size = new System.Drawing.Size(139, 24);
            this.buttonSelectGroup.TabIndex = 7;
            this.buttonSelectGroup.Text = "Select...";
            this.toolTip1.SetToolTip(this.buttonSelectGroup, "select basin or group of sites");
            this.buttonSelectGroup.UseVisualStyleBackColor = true;
            this.buttonSelectGroup.Click += new System.EventHandler(this.buttonSelectGroup_Click);
            // 
            // comboBoxCbtt
            // 
            this.comboBoxCbtt.FormattingEnabled = true;
            this.comboBoxCbtt.Location = new System.Drawing.Point(154, 16);
            this.comboBoxCbtt.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCbtt.Name = "comboBoxCbtt";
            this.comboBoxCbtt.Size = new System.Drawing.Size(301, 24);
            this.comboBoxCbtt.TabIndex = 6;
            this.comboBoxCbtt.Text = "JKPI";
            this.toolTip1.SetToolTip(this.comboBoxCbtt, "enter cbtt such as \'JKPI\'");
            this.comboBoxCbtt.SelectedIndexChanged += new System.EventHandler(this.comboBoxCbtt_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonRefresh.Location = new System.Drawing.Point(465, 50);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(79, 55);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxPcode
            // 
            this.comboBoxPcode.FormattingEnabled = true;
            this.comboBoxPcode.Items.AddRange(new object[] {
            "Snow",
            "Storage",
            "Flow",
            "Precipitation",
            "AF",
            "QD",
            "QU"});
            this.comboBoxPcode.Location = new System.Drawing.Point(154, 50);
            this.comboBoxPcode.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxPcode.Name = "comboBoxPcode";
            this.comboBoxPcode.Size = new System.Drawing.Size(301, 24);
            this.comboBoxPcode.TabIndex = 4;
            this.comboBoxPcode.Text = "Snow";
            this.toolTip1.SetToolTip(this.comboBoxPcode, "enter parameter code");
            // 
            // monthRangePicker1
            // 
            this.monthRangePicker1.AutoSize = true;
            this.monthRangePicker1.BeginningMonth = 10;
            this.monthRangePicker1.Location = new System.Drawing.Point(556, 43);
            this.monthRangePicker1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.monthRangePicker1.MonthDayRange = monthDayRange3;
            this.monthRangePicker1.Name = "monthRangePicker1";
            this.monthRangePicker1.Size = new System.Drawing.Size(445, 43);
            this.monthRangePicker1.TabIndex = 1;
            // 
            // yearSelector1
            // 
            this.yearSelector1.Location = new System.Drawing.Point(556, 9);
            this.yearSelector1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.yearSelector1.Name = "yearSelector1";
            this.yearSelector1.SelectedYears = new int[] {
        2001,
        2005};
            this.yearSelector1.Size = new System.Drawing.Size(428, 31);
            this.yearSelector1.TabIndex = 2;
            // 
            // checkBoxUseInstant
            // 
            this.checkBoxUseInstant.AutoSize = true;
            this.checkBoxUseInstant.Location = new System.Drawing.Point(369, 111);
            this.checkBoxUseInstant.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxUseInstant.Name = "checkBoxUseInstant";
            this.checkBoxUseInstant.Size = new System.Drawing.Size(135, 21);
            this.checkBoxUseInstant.TabIndex = 19;
            this.checkBoxUseInstant.Text = "Use Instant Data";
            this.checkBoxUseInstant.UseVisualStyleBackColor = true;
            // 
            // SnowGG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SnowGG";
            this.Size = new System.Drawing.Size(1323, 729);
            this.Load += new System.EventHandler(this.SnowGG_Load);
            this.VisibleChanged += new System.EventHandler(this.SnowGG_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Reclamation.TimeSeries.Forms.YearSelector yearSelector1;
        private Reclamation.TimeSeries.Forms.MonthRangePicker monthRangePicker1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxPcode;
        private System.Windows.Forms.ToolTip toolTip1;
        private Reclamation.TimeSeries.Graphing.TimeSeriesTeeChartGraph timeSeriesGraph1;
        private System.Windows.Forms.ComboBox comboBoxCbtt;
        private System.Windows.Forms.Button buttonSelectGroup;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.CheckBox checkBoxMpoll;
        private System.Windows.Forms.CheckBox checkBoxGP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAvg;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.TextBox textBoxWY2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWY1;
        private System.Windows.Forms.CheckBox checkBoxAnnotate;
        private System.Windows.Forms.TextBox textBoxPctls;
        private System.Windows.Forms.CheckBox checkBoxPctls;
        private System.Windows.Forms.CheckBox checkBoxDeltas;
        private System.Windows.Forms.TextBox textBoxMultiple;
        private System.Windows.Forms.CheckBox checkBoxUseList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToggleMonths;
        private System.Windows.Forms.CheckBox checkBoxSumList;
        private System.Windows.Forms.CheckBox checkBoxUseInstant;
    }
}
