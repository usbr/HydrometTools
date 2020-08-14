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
            Reclamation.Core.MonthDayRange monthDayRange1 = new Reclamation.Core.MonthDayRange();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseInstant = new System.Windows.Forms.CheckBox();
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSelectGroup = new System.Windows.Forms.Button();
            this.comboBoxCbtt = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxPcode = new System.Windows.Forms.ComboBox();
            this.monthRangePicker1 = new Reclamation.TimeSeries.Forms.MonthRangePicker();
            this.yearSelector1 = new Reclamation.TimeSeries.Forms.YearSelector();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelReport = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.checkBoxUseInstant);
            this.panel1.Controls.Add(this.checkBoxSumList);
            this.panel1.Controls.Add(this.buttonToggleMonths);
            this.panel1.Controls.Add(this.checkBoxUseList);
            this.panel1.Controls.Add(this.textBoxMultiple);
            this.panel1.Controls.Add(this.checkBoxDeltas);
            this.panel1.Controls.Add(this.checkBoxAnnotate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.checkBoxGP);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonSelectGroup);
            this.panel1.Controls.Add(this.comboBoxCbtt);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.comboBoxPcode);
            this.panel1.Controls.Add(this.monthRangePicker1);
            this.panel1.Controls.Add(this.yearSelector1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2646, 366);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1924, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(708, 161);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggregation";
            this.groupBox2.Visible = false;
            // 
            // checkBoxUseInstant
            // 
            this.checkBoxUseInstant.AutoSize = true;
            this.checkBoxUseInstant.Location = new System.Drawing.Point(420, 170);
            this.checkBoxUseInstant.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxUseInstant.Name = "checkBoxUseInstant";
            this.checkBoxUseInstant.Size = new System.Drawing.Size(262, 36);
            this.checkBoxUseInstant.TabIndex = 19;
            this.checkBoxUseInstant.TabStop = false;
            this.checkBoxUseInstant.Text = "Use Instant Data";
            this.checkBoxUseInstant.UseVisualStyleBackColor = true;
            // 
            // checkBoxSumList
            // 
            this.checkBoxSumList.AutoSize = true;
            this.checkBoxSumList.Enabled = false;
            this.checkBoxSumList.Location = new System.Drawing.Point(18, 279);
            this.checkBoxSumList.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxSumList.Name = "checkBoxSumList";
            this.checkBoxSumList.Size = new System.Drawing.Size(163, 36);
            this.checkBoxSumList.TabIndex = 18;
            this.checkBoxSumList.TabStop = false;
            this.checkBoxSumList.Text = "Sum List";
            this.checkBoxSumList.UseVisualStyleBackColor = true;
            // 
            // buttonToggleMonths
            // 
            this.buttonToggleMonths.Location = new System.Drawing.Point(1892, 83);
            this.buttonToggleMonths.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonToggleMonths.Name = "buttonToggleMonths";
            this.buttonToggleMonths.Size = new System.Drawing.Size(138, 76);
            this.buttonToggleMonths.TabIndex = 17;
            this.buttonToggleMonths.TabStop = false;
            this.buttonToggleMonths.Text = "Use CY";
            this.buttonToggleMonths.UseVisualStyleBackColor = true;
            this.buttonToggleMonths.Click += new System.EventHandler(this.buttonToggleMonths_Click);
            // 
            // checkBoxUseList
            // 
            this.checkBoxUseList.AutoSize = true;
            this.checkBoxUseList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxUseList.Location = new System.Drawing.Point(44, 103);
            this.checkBoxUseList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxUseList.Name = "checkBoxUseList";
            this.checkBoxUseList.Size = new System.Drawing.Size(155, 36);
            this.checkBoxUseList.TabIndex = 16;
            this.checkBoxUseList.TabStop = false;
            this.checkBoxUseList.Text = "Use List";
            this.checkBoxUseList.UseVisualStyleBackColor = true;
            this.checkBoxUseList.CheckedChanged += new System.EventHandler(this.useList_CheckedChanged);
            // 
            // textBoxMultiple
            // 
            this.textBoxMultiple.Enabled = false;
            this.textBoxMultiple.Location = new System.Drawing.Point(218, 101);
            this.textBoxMultiple.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMultiple.Name = "textBoxMultiple";
            this.textBoxMultiple.Size = new System.Drawing.Size(568, 38);
            this.textBoxMultiple.TabIndex = 15;
            this.textBoxMultiple.TabStop = false;
            // 
            // checkBoxDeltas
            // 
            this.checkBoxDeltas.AutoSize = true;
            this.checkBoxDeltas.Location = new System.Drawing.Point(18, 227);
            this.checkBoxDeltas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxDeltas.Name = "checkBoxDeltas";
            this.checkBoxDeltas.Size = new System.Drawing.Size(356, 36);
            this.checkBoxDeltas.TabIndex = 14;
            this.checkBoxDeltas.TabStop = false;
            this.checkBoxDeltas.Text = "Apply Deltas to 1st Year";
            this.checkBoxDeltas.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnnotate
            // 
            this.checkBoxAnnotate.AutoSize = true;
            this.checkBoxAnnotate.Checked = true;
            this.checkBoxAnnotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnnotate.Location = new System.Drawing.Point(18, 170);
            this.checkBoxAnnotate.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxAnnotate.Name = "checkBoxAnnotate";
            this.checkBoxAnnotate.Size = new System.Drawing.Size(218, 36);
            this.checkBoxAnnotate.TabIndex = 13;
            this.checkBoxAnnotate.TabStop = false;
            this.checkBoxAnnotate.Text = "Show Tooltip";
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
            this.groupBox1.Location = new System.Drawing.Point(1018, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.groupBox1.Size = new System.Drawing.Size(890, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Use";
            // 
            // textBoxPctls
            // 
            this.textBoxPctls.Location = new System.Drawing.Point(612, 99);
            this.textBoxPctls.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.textBoxPctls.Name = "textBoxPctls";
            this.textBoxPctls.Size = new System.Drawing.Size(240, 38);
            this.textBoxPctls.TabIndex = 7;
            this.textBoxPctls.TabStop = false;
            this.textBoxPctls.Text = "10, 50, 90";
            // 
            // checkBoxPctls
            // 
            this.checkBoxPctls.AutoSize = true;
            this.checkBoxPctls.Location = new System.Drawing.Point(414, 103);
            this.checkBoxPctls.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxPctls.Name = "checkBoxPctls";
            this.checkBoxPctls.Size = new System.Drawing.Size(195, 36);
            this.checkBoxPctls.TabIndex = 6;
            this.checkBoxPctls.TabStop = false;
            this.checkBoxPctls.Text = "Percentiles";
            this.checkBoxPctls.UseVisualStyleBackColor = true;
            // 
            // textBoxWY2
            // 
            this.textBoxWY2.Location = new System.Drawing.Point(278, 41);
            this.textBoxWY2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.textBoxWY2.Name = "textBoxWY2";
            this.textBoxWY2.Size = new System.Drawing.Size(104, 38);
            this.textBoxWY2.TabIndex = 5;
            this.textBoxWY2.TabStop = false;
            this.textBoxWY2.Text = "2010";
            this.textBoxWY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // textBoxWY1
            // 
            this.textBoxWY1.Location = new System.Drawing.Point(98, 41);
            this.textBoxWY1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.textBoxWY1.Name = "textBoxWY1";
            this.textBoxWY1.Size = new System.Drawing.Size(104, 38);
            this.textBoxWY1.TabIndex = 3;
            this.textBoxWY1.TabStop = false;
            this.textBoxWY1.Text = "1980";
            this.textBoxWY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxAvg
            // 
            this.checkBoxAvg.AutoSize = true;
            this.checkBoxAvg.Location = new System.Drawing.Point(32, 103);
            this.checkBoxAvg.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxAvg.Name = "checkBoxAvg";
            this.checkBoxAvg.Size = new System.Drawing.Size(102, 36);
            this.checkBoxAvg.TabIndex = 2;
            this.checkBoxAvg.TabStop = false;
            this.checkBoxAvg.Text = "Avg";
            this.checkBoxAvg.UseVisualStyleBackColor = true;
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Location = new System.Drawing.Point(160, 101);
            this.checkBoxMax.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(106, 36);
            this.checkBoxMax.TabIndex = 1;
            this.checkBoxMax.TabStop = false;
            this.checkBoxMax.Text = "Max";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Location = new System.Drawing.Point(290, 101);
            this.checkBoxMin.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(99, 36);
            this.checkBoxMin.TabIndex = 0;
            this.checkBoxMin.TabStop = false;
            this.checkBoxMin.Text = "Min";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            // 
            // checkBoxGP
            // 
            this.checkBoxGP.AutoSize = true;
            this.checkBoxGP.Location = new System.Drawing.Point(420, 227);
            this.checkBoxGP.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.checkBoxGP.Name = "checkBoxGP";
            this.checkBoxGP.Size = new System.Drawing.Size(250, 36);
            this.checkBoxGP.TabIndex = 10;
            this.checkBoxGP.TabStop = false;
            this.checkBoxGP.Text = "include  se_avg";
            this.checkBoxGP.UseVisualStyleBackColor = true;
            this.checkBoxGP.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(810, 29);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(184, 46);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.TabStop = false;
            this.buttonNext.Text = ">";
            this.toolTip1.SetToolTip(this.buttonNext, "advance to next site");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSelectGroup
            // 
            this.buttonSelectGroup.AutoEllipsis = true;
            this.buttonSelectGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectGroup.Location = new System.Drawing.Point(18, 31);
            this.buttonSelectGroup.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonSelectGroup.Name = "buttonSelectGroup";
            this.buttonSelectGroup.Size = new System.Drawing.Size(188, 46);
            this.buttonSelectGroup.TabIndex = 7;
            this.buttonSelectGroup.TabStop = false;
            this.buttonSelectGroup.Text = "Select...";
            this.toolTip1.SetToolTip(this.buttonSelectGroup, "select basin or group of sites");
            this.buttonSelectGroup.UseVisualStyleBackColor = true;
            this.buttonSelectGroup.Click += new System.EventHandler(this.buttonSelectGroup_Click);
            // 
            // comboBoxCbtt
            // 
            this.comboBoxCbtt.FormattingEnabled = true;
            this.comboBoxCbtt.Location = new System.Drawing.Point(218, 31);
            this.comboBoxCbtt.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.comboBoxCbtt.Name = "comboBoxCbtt";
            this.comboBoxCbtt.Size = new System.Drawing.Size(272, 39);
            this.comboBoxCbtt.TabIndex = 2;
            this.comboBoxCbtt.Text = "JKPI";
            this.toolTip1.SetToolTip(this.comboBoxCbtt, "enter cbtt such as \'JKPI\'");
            this.comboBoxCbtt.SelectedIndexChanged += new System.EventHandler(this.comboBoxCbtt_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonRefresh.Location = new System.Drawing.Point(810, 101);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(184, 128);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Query Data";
            this.buttonRefresh.UseVisualStyleBackColor = false;
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
            this.comboBoxPcode.Location = new System.Drawing.Point(514, 31);
            this.comboBoxPcode.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.comboBoxPcode.Name = "comboBoxPcode";
            this.comboBoxPcode.Size = new System.Drawing.Size(272, 39);
            this.comboBoxPcode.TabIndex = 4;
            this.comboBoxPcode.Text = "Snow";
            this.toolTip1.SetToolTip(this.comboBoxPcode, "enter parameter code");
            // 
            // monthRangePicker1
            // 
            this.monthRangePicker1.AutoSize = true;
            this.monthRangePicker1.BeginningMonth = 10;
            this.monthRangePicker1.Location = new System.Drawing.Point(1018, 83);
            this.monthRangePicker1.Margin = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.monthRangePicker1.MonthDayRange = monthDayRange1;
            this.monthRangePicker1.Name = "monthRangePicker1";
            this.monthRangePicker1.Size = new System.Drawing.Size(1734, 161);
            this.monthRangePicker1.TabIndex = 1;
            this.monthRangePicker1.TabStop = false;
            // 
            // yearSelector1
            // 
            this.yearSelector1.Location = new System.Drawing.Point(1018, 17);
            this.yearSelector1.Margin = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.yearSelector1.Name = "yearSelector1";
            this.yearSelector1.SelectedYears = new int[] {
        2001,
        2005};
            this.yearSelector1.Size = new System.Drawing.Size(856, 60);
            this.yearSelector1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageChart);
            this.tabControl1.Controls.Add(this.tabPageTable);
            this.tabControl1.Location = new System.Drawing.Point(0, 368);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2640, 1038);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPageChart
            // 
            this.tabPageChart.Location = new System.Drawing.Point(10, 48);
            this.tabPageChart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageChart.Size = new System.Drawing.Size(2620, 980);
            this.tabPageChart.TabIndex = 1;
            this.tabPageChart.Text = "Chart";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.dataGridView1);
            this.tabPageTable.Controls.Add(this.panel2);
            this.tabPageTable.Location = new System.Drawing.Point(10, 48);
            this.tabPageTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageTable.Size = new System.Drawing.Size(2620, 980);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "DataTable";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2624, 903);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.linkLabelReport);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2624, 72);
            this.panel2.TabIndex = 0;
            // 
            // linkLabelReport
            // 
            this.linkLabelReport.AutoSize = true;
            this.linkLabelReport.Location = new System.Drawing.Point(10, 12);
            this.linkLabelReport.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkLabelReport.Name = "linkLabelReport";
            this.linkLabelReport.Size = new System.Drawing.Size(211, 32);
            this.linkLabelReport.TabIndex = 4;
            this.linkLabelReport.TabStop = true;
            this.linkLabelReport.Text = "open with excel";
            this.linkLabelReport.Visible = false;
            this.linkLabelReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReport_LinkClicked);
            // 
            // SnowGG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "SnowGG";
            this.Size = new System.Drawing.Size(2646, 1412);
            this.Load += new System.EventHandler(this.SnowGG_Load);
            this.VisibleChanged += new System.EventHandler(this.SnowGG_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelReport;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
