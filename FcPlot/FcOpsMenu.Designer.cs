namespace FcPlot
{
    partial class FcOpsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FcOpsMenu));
            this.buttonOperate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInflowCode = new System.Windows.Forms.TextBox();
            this.textBoxOutflowCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSpace = new System.Windows.Forms.TextBox();
            this.textBoxInflowScale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOutflowScale = new System.Windows.Forms.TextBox();
            this.textBoxDams = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownInflowYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOutflowYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInflowShift = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOutflowShift = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxUseCustomOutflow = new System.Windows.Forms.CheckBox();
            this.dateTimePickerSimStart = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxEspTraces = new System.Windows.Forms.ComboBox();
            this.comboBoxEspDay = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonGetEspData = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.radioButtonWSFcast = new System.Windows.Forms.RadioButton();
            this.radioButtonNFcast = new System.Windows.Forms.RadioButton();
            this.textBoxRfcNode = new System.Windows.Forms.TextBox();
            this.checkBoxUseCustomInflow = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxRedrawGraph = new System.Windows.Forms.CheckBox();
            this.checkBoxHideLegend = new System.Windows.Forms.CheckBox();
            this.buttonPlotEspData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInflowYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutflowYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInflowShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutflowShift)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOperate
            // 
            this.buttonOperate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOperate.Location = new System.Drawing.Point(268, 564);
            this.buttonOperate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOperate.Name = "buttonOperate";
            this.buttonOperate.Size = new System.Drawing.Size(105, 27);
            this.buttonOperate.TabIndex = 0;
            this.buttonOperate.Text = "Operate";
            this.buttonOperate.UseVisualStyleBackColor = true;
            this.buttonOperate.Click += new System.EventHandler(this.buttonOperate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inflow Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Outflow Data";
            // 
            // textBoxInflowCode
            // 
            this.textBoxInflowCode.Enabled = false;
            this.textBoxInflowCode.Location = new System.Drawing.Point(90, 20);
            this.textBoxInflowCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInflowCode.Name = "textBoxInflowCode";
            this.textBoxInflowCode.Size = new System.Drawing.Size(95, 20);
            this.textBoxInflowCode.TabIndex = 3;
            // 
            // textBoxOutflowCode
            // 
            this.textBoxOutflowCode.Enabled = false;
            this.textBoxOutflowCode.Location = new System.Drawing.Point(89, 17);
            this.textBoxOutflowCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOutflowCode.Name = "textBoxOutflowCode";
            this.textBoxOutflowCode.Size = new System.Drawing.Size(95, 20);
            this.textBoxOutflowCode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Space";
            // 
            // textBoxSpace
            // 
            this.textBoxSpace.Enabled = false;
            this.textBoxSpace.Location = new System.Drawing.Point(72, 9);
            this.textBoxSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSpace.Name = "textBoxSpace";
            this.textBoxSpace.Size = new System.Drawing.Size(95, 20);
            this.textBoxSpace.TabIndex = 6;
            // 
            // textBoxInflowScale
            // 
            this.textBoxInflowScale.Enabled = false;
            this.textBoxInflowScale.Location = new System.Drawing.Point(302, 44);
            this.textBoxInflowScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInflowScale.Name = "textBoxInflowScale";
            this.textBoxInflowScale.Size = new System.Drawing.Size(59, 20);
            this.textBoxInflowScale.TabIndex = 7;
            this.textBoxInflowScale.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Water Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Water Year";
            // 
            // textBoxOutflowScale
            // 
            this.textBoxOutflowScale.Location = new System.Drawing.Point(302, 39);
            this.textBoxOutflowScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOutflowScale.Name = "textBoxOutflowScale";
            this.textBoxOutflowScale.Size = new System.Drawing.Size(59, 20);
            this.textBoxOutflowScale.TabIndex = 9;
            this.textBoxOutflowScale.Text = "1";
            // 
            // textBoxDams
            // 
            this.textBoxDams.Enabled = false;
            this.textBoxDams.Location = new System.Drawing.Point(268, 9);
            this.textBoxDams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDams.Name = "textBoxDams";
            this.textBoxDams.Size = new System.Drawing.Size(106, 20);
            this.textBoxDams.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dam(s)";
            // 
            // numericUpDownInflowYear
            // 
            this.numericUpDownInflowYear.Enabled = false;
            this.numericUpDownInflowYear.Location = new System.Drawing.Point(280, 20);
            this.numericUpDownInflowYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownInflowYear.Name = "numericUpDownInflowYear";
            this.numericUpDownInflowYear.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownInflowYear.TabIndex = 13;
            // 
            // numericUpDownOutflowYear
            // 
            this.numericUpDownOutflowYear.Location = new System.Drawing.Point(280, 17);
            this.numericUpDownOutflowYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownOutflowYear.Name = "numericUpDownOutflowYear";
            this.numericUpDownOutflowYear.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownOutflowYear.TabIndex = 14;
            // 
            // numericUpDownInflowShift
            // 
            this.numericUpDownInflowShift.Enabled = false;
            this.numericUpDownInflowShift.Location = new System.Drawing.Point(189, 42);
            this.numericUpDownInflowShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownInflowShift.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownInflowShift.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDownInflowShift.Name = "numericUpDownInflowShift";
            this.numericUpDownInflowShift.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownInflowShift.TabIndex = 15;
            // 
            // numericUpDownOutflowShift
            // 
            this.numericUpDownOutflowShift.Location = new System.Drawing.Point(189, 40);
            this.numericUpDownOutflowShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownOutflowShift.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownOutflowShift.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numericUpDownOutflowShift.Name = "numericUpDownOutflowShift";
            this.numericUpDownOutflowShift.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownOutflowShift.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Day Shift";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Day Shift";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Scaler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Scaler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.checkBoxUseCustomOutflow);
            this.groupBox1.Location = new System.Drawing.Point(20, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(340, 221);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Outflow";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(8, 181);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 35);
            this.textBox1.TabIndex = 49;
            this.textBox1.Text = "Outflows will revert to the selected analog year if the max end date is less than" +
    " the end of the WY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(326, 137);
            this.dataGridView1.TabIndex = 49;
            // 
            // checkBoxUseCustomOutflow
            // 
            this.checkBoxUseCustomOutflow.AutoSize = true;
            this.checkBoxUseCustomOutflow.Checked = true;
            this.checkBoxUseCustomOutflow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseCustomOutflow.Location = new System.Drawing.Point(8, 17);
            this.checkBoxUseCustomOutflow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxUseCustomOutflow.Name = "checkBoxUseCustomOutflow";
            this.checkBoxUseCustomOutflow.Size = new System.Drawing.Size(122, 17);
            this.checkBoxUseCustomOutflow.TabIndex = 34;
            this.checkBoxUseCustomOutflow.Text = "Use Custom Outflow";
            this.checkBoxUseCustomOutflow.UseVisualStyleBackColor = true;
            this.checkBoxUseCustomOutflow.CheckedChanged += new System.EventHandler(this.checkBoxUseCustomOutflow_CheckedChanged);
            // 
            // dateTimePickerSimStart
            // 
            this.dateTimePickerSimStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerSimStart.CustomFormat = "MMM-d";
            this.dateTimePickerSimStart.Enabled = false;
            this.dateTimePickerSimStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSimStart.Location = new System.Drawing.Point(8, 573);
            this.dateTimePickerSimStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerSimStart.Name = "dateTimePickerSimStart";
            this.dateTimePickerSimStart.ShowUpDown = true;
            this.dateTimePickerSimStart.Size = new System.Drawing.Size(69, 20);
            this.dateTimePickerSimStart.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 574);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Simulation Start Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPlotEspData);
            this.groupBox2.Controls.Add(this.comboBoxEspTraces);
            this.groupBox2.Controls.Add(this.comboBoxEspDay);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.buttonGetEspData);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.radioButtonWSFcast);
            this.groupBox2.Controls.Add(this.radioButtonNFcast);
            this.groupBox2.Controls.Add(this.textBoxRfcNode);
            this.groupBox2.Controls.Add(this.checkBoxUseCustomInflow);
            this.groupBox2.Location = new System.Drawing.Point(20, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(340, 144);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Inflow";
            // 
            // comboBoxEspTraces
            // 
            this.comboBoxEspTraces.FormattingEnabled = true;
            this.comboBoxEspTraces.Items.AddRange(new object[] {
            "Get ESP Data..."});
            this.comboBoxEspTraces.Location = new System.Drawing.Point(175, 114);
            this.comboBoxEspTraces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEspTraces.Name = "comboBoxEspTraces";
            this.comboBoxEspTraces.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEspTraces.TabIndex = 46;
            // 
            // comboBoxEspDay
            // 
            this.comboBoxEspDay.FormattingEnabled = true;
            this.comboBoxEspDay.Items.AddRange(new object[] {
            "0 | zero-day (climatology)",
            "10 | 10-day deterministic",
            "M | HEFS"});
            this.comboBoxEspDay.Location = new System.Drawing.Point(175, 63);
            this.comboBoxEspDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEspDay.Name = "comboBoxEspDay";
            this.comboBoxEspDay.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEspDay.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(81, 114);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "ESP Trace Year";
            // 
            // buttonGetEspData
            // 
            this.buttonGetEspData.Location = new System.Drawing.Point(130, 89);
            this.buttonGetEspData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetEspData.Name = "buttonGetEspData";
            this.buttonGetEspData.Size = new System.Drawing.Size(100, 21);
            this.buttonGetEspData.TabIndex = 42;
            this.buttonGetEspData.Text = "Get ESP Data";
            this.buttonGetEspData.UseVisualStyleBackColor = true;
            this.buttonGetEspData.Click += new System.EventHandler(this.buttonGetEspData_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(137, 69);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "ESP";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(88, 42);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Forecast Node";
            // 
            // radioButtonWSFcast
            // 
            this.radioButtonWSFcast.AutoSize = true;
            this.radioButtonWSFcast.Location = new System.Drawing.Point(247, 16);
            this.radioButtonWSFcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonWSFcast.Name = "radioButtonWSFcast";
            this.radioButtonWSFcast.Size = new System.Drawing.Size(89, 17);
            this.radioButtonWSFcast.TabIndex = 38;
            this.radioButtonWSFcast.Text = "Water Supply";
            this.radioButtonWSFcast.UseVisualStyleBackColor = true;
            // 
            // radioButtonNFcast
            // 
            this.radioButtonNFcast.AutoSize = true;
            this.radioButtonNFcast.Checked = true;
            this.radioButtonNFcast.Location = new System.Drawing.Point(178, 16);
            this.radioButtonNFcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNFcast.Name = "radioButtonNFcast";
            this.radioButtonNFcast.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNFcast.TabIndex = 37;
            this.radioButtonNFcast.TabStop = true;
            this.radioButtonNFcast.Text = "Natural";
            this.radioButtonNFcast.UseVisualStyleBackColor = true;
            // 
            // textBoxRfcNode
            // 
            this.textBoxRfcNode.Location = new System.Drawing.Point(175, 38);
            this.textBoxRfcNode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRfcNode.Name = "textBoxRfcNode";
            this.textBoxRfcNode.Size = new System.Drawing.Size(158, 20);
            this.textBoxRfcNode.TabIndex = 36;
            this.textBoxRfcNode.Text = "textBoxRfcNode";
            // 
            // checkBoxUseCustomInflow
            // 
            this.checkBoxUseCustomInflow.AutoSize = true;
            this.checkBoxUseCustomInflow.Checked = true;
            this.checkBoxUseCustomInflow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseCustomInflow.Location = new System.Drawing.Point(8, 17);
            this.checkBoxUseCustomInflow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxUseCustomInflow.Name = "checkBoxUseCustomInflow";
            this.checkBoxUseCustomInflow.Size = new System.Drawing.Size(137, 17);
            this.checkBoxUseCustomInflow.TabIndex = 35;
            this.checkBoxUseCustomInflow.Text = "Use RFC ESP Forecast";
            this.checkBoxUseCustomInflow.UseVisualStyleBackColor = true;
            this.checkBoxUseCustomInflow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.textBoxInflowCode);
            this.groupBox3.Controls.Add(this.textBoxInflowScale);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDownInflowYear);
            this.groupBox3.Controls.Add(this.numericUpDownInflowShift);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(8, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(364, 217);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inflow";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxOutflowCode);
            this.groupBox4.Controls.Add(this.textBoxOutflowScale);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.numericUpDownOutflowYear);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.numericUpDownOutflowShift);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(8, 255);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(364, 288);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Outflow";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(170, 13);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "AF";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(376, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // checkBoxRedrawGraph
            // 
            this.checkBoxRedrawGraph.AutoSize = true;
            this.checkBoxRedrawGraph.Checked = true;
            this.checkBoxRedrawGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRedrawGraph.Location = new System.Drawing.Point(8, 551);
            this.checkBoxRedrawGraph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRedrawGraph.Name = "checkBoxRedrawGraph";
            this.checkBoxRedrawGraph.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxRedrawGraph.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRedrawGraph.TabIndex = 47;
            this.checkBoxRedrawGraph.Text = "Redraw Graph";
            this.checkBoxRedrawGraph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRedrawGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxHideLegend
            // 
            this.checkBoxHideLegend.AutoSize = true;
            this.checkBoxHideLegend.Location = new System.Drawing.Point(118, 551);
            this.checkBoxHideLegend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxHideLegend.Name = "checkBoxHideLegend";
            this.checkBoxHideLegend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxHideLegend.Size = new System.Drawing.Size(87, 17);
            this.checkBoxHideLegend.TabIndex = 48;
            this.checkBoxHideLegend.Text = "Hide Legend";
            this.checkBoxHideLegend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHideLegend.UseVisualStyleBackColor = true;
            // 
            // buttonPlotEspData
            // 
            this.buttonPlotEspData.Location = new System.Drawing.Point(234, 88);
            this.buttonPlotEspData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlotEspData.Name = "buttonPlotEspData";
            this.buttonPlotEspData.Size = new System.Drawing.Size(100, 21);
            this.buttonPlotEspData.TabIndex = 47;
            this.buttonPlotEspData.Text = "Plot ESP Data";
            this.buttonPlotEspData.UseVisualStyleBackColor = true;
            this.buttonPlotEspData.Click += new System.EventHandler(this.buttonPlotEspData_Click);
            // 
            // FcOpsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 619);
            this.Controls.Add(this.checkBoxHideLegend);
            this.Controls.Add(this.checkBoxRedrawGraph);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePickerSimStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDams);
            this.Controls.Add(this.textBoxSpace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOperate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FcOpsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Flood Control Operations Menu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInflowYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutflowYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInflowShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutflowShift)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonOperate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxInflowCode;
        public System.Windows.Forms.TextBox textBoxOutflowCode;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxSpace;
        public System.Windows.Forms.TextBox textBoxInflowScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxOutflowScale;
        public System.Windows.Forms.TextBox textBoxDams;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numericUpDownInflowYear;
        public System.Windows.Forms.NumericUpDown numericUpDownOutflowYear;
        public System.Windows.Forms.NumericUpDown numericUpDownInflowShift;
        public System.Windows.Forms.NumericUpDown numericUpDownOutflowShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox checkBoxUseCustomOutflow;
        public System.Windows.Forms.DateTimePicker dateTimePickerSimStart;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonGetEspData;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton radioButtonWSFcast;
        private System.Windows.Forms.RadioButton radioButtonNFcast;
        public System.Windows.Forms.TextBox textBoxRfcNode;
        public System.Windows.Forms.CheckBox checkBoxUseCustomInflow;
        private System.Windows.Forms.ComboBox comboBoxEspDay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ComboBox comboBoxEspTraces;
        public System.Windows.Forms.CheckBox checkBoxRedrawGraph;
        public System.Windows.Forms.CheckBox checkBoxHideLegend;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPlotEspData;
    }
}