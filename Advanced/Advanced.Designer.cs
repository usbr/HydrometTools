namespace HydrometTools.Advanced
{
    partial class AdvancedControl
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
            this.rawDataInput1 = new HydrometTools.RawDataInput();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.archiverInput1 = new HydrometTools.Advanced.ArchiverInput();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mathInput1 = new HydrometTools.MathInput();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dayfileInsert1 = new HydrometTools.Advanced.DayfileInsert();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.archiverFileList1 = new HydrometTools.Advanced.ArchiverFileList();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVms = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gpFixInflow1 = new HydrometTools.GpFixInflow();
            this.tabPageLinux = new System.Windows.Forms.TabPage();
            this.tabControlLinux = new System.Windows.Forms.TabControl();
            this.tabPageSites = new System.Windows.Forms.TabPage();
            this.tabPageMCFToDecodes = new System.Windows.Forms.TabPage();
            this.mcf2Decodes1 = new HydrometTools.Advanced.Mcf2Decodes();
            this.tabPageQuality = new System.Windows.Forms.TabPage();
            this.dataGridViewQuality = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHoursBack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDownloadNessid = new System.Windows.Forms.Button();
            this.textBoxNessid = new System.Windows.Forms.TextBox();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDownloadQuality = new System.Windows.Forms.Button();
            this.textBoxCbttQuality = new System.Windows.Forms.TextBox();
            this.tabPageEncode = new System.Windows.Forms.TabPage();
            this.encodeAscii1 = new HydrometTools.Advanced.ManualEncodeDecode.EncodeAscii();
            this.tabPageEquations = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageVms.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPageLinux.SuspendLayout();
            this.tabControlLinux.SuspendLayout();
            this.tabPageMCFToDecodes.SuspendLayout();
            this.tabPageQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuality)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageEncode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rawDataInput1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(440, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "rawdata";
            // 
            // rawDataInput1
            // 
            this.rawDataInput1.Location = new System.Drawing.Point(8, 23);
            this.rawDataInput1.Margin = new System.Windows.Forms.Padding(5);
            this.rawDataInput1.Name = "rawDataInput1";
            this.rawDataInput1.Size = new System.Drawing.Size(389, 199);
            this.rawDataInput1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.archiverInput1);
            this.groupBox2.Location = new System.Drawing.Point(8, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(440, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "daily calculation (archiver)";
            // 
            // archiverInput1
            // 
            this.archiverInput1.Location = new System.Drawing.Point(8, 23);
            this.archiverInput1.Margin = new System.Windows.Forms.Padding(5);
            this.archiverInput1.Name = "archiverInput1";
            this.archiverInput1.Size = new System.Drawing.Size(404, 169);
            this.archiverInput1.TabIndex = 1;
            this.archiverInput1.Load += new System.EventHandler(this.archiverInput1_Load);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mathInput1);
            this.groupBox3.Location = new System.Drawing.Point(456, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(436, 337);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "rating table calculation";
            // 
            // mathInput1
            // 
            this.mathInput1.Location = new System.Drawing.Point(8, 23);
            this.mathInput1.Margin = new System.Windows.Forms.Padding(5);
            this.mathInput1.Name = "mathInput1";
            this.mathInput1.Size = new System.Drawing.Size(420, 305);
            this.mathInput1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dayfileInsert1);
            this.groupBox4.Location = new System.Drawing.Point(456, 352);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(436, 222);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "insert zeros into instant database (dayfiles)";
            // 
            // dayfileInsert1
            // 
            this.dayfileInsert1.Location = new System.Drawing.Point(8, 23);
            this.dayfileInsert1.Margin = new System.Windows.Forms.Padding(5);
            this.dayfileInsert1.Name = "dayfileInsert1";
            this.dayfileInsert1.Size = new System.Drawing.Size(361, 170);
            this.dayfileInsert1.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.archiverFileList1);
            this.groupBox5.Location = new System.Drawing.Point(8, 458);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(440, 252);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "daily calculation -- multiple sites in txt file";
            // 
            // archiverFileList1
            // 
            this.archiverFileList1.Location = new System.Drawing.Point(5, 27);
            this.archiverFileList1.Margin = new System.Windows.Forms.Padding(5);
            this.archiverFileList1.Name = "archiverFileList1";
            this.archiverFileList1.Size = new System.Drawing.Size(423, 207);
            this.archiverFileList1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVms);
            this.tabControl1.Controls.Add(this.tabPageLinux);
            this.tabControl1.Controls.Add(this.tabPageQuality);
            this.tabControl1.Controls.Add(this.tabPageEncode);
            this.tabControl1.Controls.Add(this.tabPageEquations);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 842);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageVms
            // 
            this.tabPageVms.Controls.Add(this.groupBox6);
            this.tabPageVms.Controls.Add(this.groupBox1);
            this.tabPageVms.Controls.Add(this.groupBox4);
            this.tabPageVms.Controls.Add(this.groupBox5);
            this.tabPageVms.Controls.Add(this.groupBox3);
            this.tabPageVms.Controls.Add(this.groupBox2);
            this.tabPageVms.Location = new System.Drawing.Point(4, 25);
            this.tabPageVms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageVms.Name = "tabPageVms";
            this.tabPageVms.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageVms.Size = new System.Drawing.Size(975, 813);
            this.tabPageVms.TabIndex = 0;
            this.tabPageVms.Text = "openvms";
            this.tabPageVms.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gpFixInflow1);
            this.groupBox6.Location = new System.Drawing.Point(456, 581);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(436, 194);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GP FIXINFLO";
            // 
            // gpFixInflow1
            // 
            this.gpFixInflow1.Location = new System.Drawing.Point(8, 22);
            this.gpFixInflow1.Margin = new System.Windows.Forms.Padding(4);
            this.gpFixInflow1.Name = "gpFixInflow1";
            this.gpFixInflow1.Size = new System.Drawing.Size(420, 165);
            this.gpFixInflow1.TabIndex = 0;
            // 
            // tabPageLinux
            // 
            this.tabPageLinux.Controls.Add(this.tabControlLinux);
            this.tabPageLinux.Location = new System.Drawing.Point(4, 25);
            this.tabPageLinux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLinux.Name = "tabPageLinux";
            this.tabPageLinux.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLinux.Size = new System.Drawing.Size(975, 813);
            this.tabPageLinux.TabIndex = 1;
            this.tabPageLinux.Text = "linux";
            this.tabPageLinux.UseVisualStyleBackColor = true;
            // 
            // tabControlLinux
            // 
            this.tabControlLinux.Controls.Add(this.tabPageSites);
            this.tabControlLinux.Controls.Add(this.tabPageMCFToDecodes);
            this.tabControlLinux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLinux.Location = new System.Drawing.Point(3, 2);
            this.tabControlLinux.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlLinux.Name = "tabControlLinux";
            this.tabControlLinux.SelectedIndex = 0;
            this.tabControlLinux.Size = new System.Drawing.Size(969, 809);
            this.tabControlLinux.TabIndex = 1;
            this.tabControlLinux.SelectedIndexChanged += new System.EventHandler(this.tabControlLinux_SelectedIndexChanged);
            // 
            // tabPageSites
            // 
            this.tabPageSites.Location = new System.Drawing.Point(4, 25);
            this.tabPageSites.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSites.Name = "tabPageSites";
            this.tabPageSites.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSites.Size = new System.Drawing.Size(961, 780);
            this.tabPageSites.TabIndex = 0;
            this.tabPageSites.Text = "sites";
            this.tabPageSites.UseVisualStyleBackColor = true;
            // 
            // tabPageMCFToDecodes
            // 
            this.tabPageMCFToDecodes.Controls.Add(this.mcf2Decodes1);
            this.tabPageMCFToDecodes.Location = new System.Drawing.Point(4, 25);
            this.tabPageMCFToDecodes.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMCFToDecodes.Name = "tabPageMCFToDecodes";
            this.tabPageMCFToDecodes.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMCFToDecodes.Size = new System.Drawing.Size(961, 780);
            this.tabPageMCFToDecodes.TabIndex = 1;
            this.tabPageMCFToDecodes.Text = "mcf-->decodes";
            this.tabPageMCFToDecodes.UseVisualStyleBackColor = true;
            // 
            // mcf2Decodes1
            // 
            this.mcf2Decodes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcf2Decodes1.Location = new System.Drawing.Point(4, 4);
            this.mcf2Decodes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mcf2Decodes1.Name = "mcf2Decodes1";
            this.mcf2Decodes1.Size = new System.Drawing.Size(953, 772);
            this.mcf2Decodes1.TabIndex = 0;
            // 
            // tabPageQuality
            // 
            this.tabPageQuality.Controls.Add(this.dataGridViewQuality);
            this.tabPageQuality.Controls.Add(this.panel1);
            this.tabPageQuality.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageQuality.Name = "tabPageQuality";
            this.tabPageQuality.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageQuality.Size = new System.Drawing.Size(975, 813);
            this.tabPageQuality.TabIndex = 2;
            this.tabPageQuality.Text = "quality";
            this.tabPageQuality.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQuality
            // 
            this.dataGridViewQuality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuality.Location = new System.Drawing.Point(3, 108);
            this.dataGridViewQuality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewQuality.Name = "dataGridViewQuality";
            this.dataGridViewQuality.RowTemplate.Height = 24;
            this.dataGridViewQuality.Size = new System.Drawing.Size(969, 703);
            this.dataGridViewQuality.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxHoursBack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonDownloadNessid);
            this.panel1.Controls.Add(this.textBoxNessid);
            this.panel1.Controls.Add(this.linkLabelHelp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonDownloadQuality);
            this.panel1.Controls.Add(this.textBoxCbttQuality);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 106);
            this.panel1.TabIndex = 1;
            // 
            // textBoxHoursBack
            // 
            this.textBoxHoursBack.Location = new System.Drawing.Point(121, 14);
            this.textBoxHoursBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHoursBack.Name = "textBoxHoursBack";
            this.textBoxHoursBack.Size = new System.Drawing.Size(77, 22);
            this.textBoxHoursBack.TabIndex = 9;
            this.textBoxHoursBack.Text = "24";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "hours back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "nessid";
            // 
            // buttonDownloadNessid
            // 
            this.buttonDownloadNessid.Location = new System.Drawing.Point(147, 75);
            this.buttonDownloadNessid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadNessid.Name = "buttonDownloadNessid";
            this.buttonDownloadNessid.Size = new System.Drawing.Size(77, 23);
            this.buttonDownloadNessid.TabIndex = 6;
            this.buttonDownloadNessid.Text = "Download";
            this.buttonDownloadNessid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDownloadNessid.UseVisualStyleBackColor = true;
            this.buttonDownloadNessid.Click += new System.EventHandler(this.buttonDownloadNessid_Click);
            // 
            // textBoxNessid
            // 
            this.textBoxNessid.Location = new System.Drawing.Point(63, 75);
            this.textBoxNessid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNessid.Name = "textBoxNessid";
            this.textBoxNessid.Size = new System.Drawing.Size(77, 22);
            this.textBoxNessid.TabIndex = 5;
            this.textBoxNessid.Text = "34748654";
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(357, 34);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(35, 17);
            this.linkLabelHelp.TabIndex = 4;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "help";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "cbtt";
            // 
            // buttonDownloadQuality
            // 
            this.buttonDownloadQuality.Location = new System.Drawing.Point(147, 42);
            this.buttonDownloadQuality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownloadQuality.Name = "buttonDownloadQuality";
            this.buttonDownloadQuality.Size = new System.Drawing.Size(77, 23);
            this.buttonDownloadQuality.TabIndex = 2;
            this.buttonDownloadQuality.Text = "Download";
            this.buttonDownloadQuality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDownloadQuality.UseVisualStyleBackColor = true;
            this.buttonDownloadQuality.Click += new System.EventHandler(this.buttonDownloadQuality_Click);
            // 
            // textBoxCbttQuality
            // 
            this.textBoxCbttQuality.Location = new System.Drawing.Point(63, 42);
            this.textBoxCbttQuality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCbttQuality.Name = "textBoxCbttQuality";
            this.textBoxCbttQuality.Size = new System.Drawing.Size(77, 22);
            this.textBoxCbttQuality.TabIndex = 0;
            this.textBoxCbttQuality.Text = "bigi";
            // 
            // tabPageEncode
            // 
            this.tabPageEncode.Controls.Add(this.encodeAscii1);
            this.tabPageEncode.Location = new System.Drawing.Point(4, 25);
            this.tabPageEncode.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEncode.Name = "tabPageEncode";
            this.tabPageEncode.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEncode.Size = new System.Drawing.Size(975, 813);
            this.tabPageEncode.TabIndex = 3;
            this.tabPageEncode.Text = "encode";
            this.tabPageEncode.UseVisualStyleBackColor = true;
            // 
            // encodeAscii1
            // 
            this.encodeAscii1.Location = new System.Drawing.Point(36, 41);
            this.encodeAscii1.Margin = new System.Windows.Forms.Padding(5);
            this.encodeAscii1.Name = "encodeAscii1";
            this.encodeAscii1.Size = new System.Drawing.Size(608, 366);
            this.encodeAscii1.TabIndex = 0;
            // 
            // tabPageEquations
            // 
            this.tabPageEquations.Location = new System.Drawing.Point(4, 25);
            this.tabPageEquations.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEquations.Name = "tabPageEquations";
            this.tabPageEquations.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEquations.Size = new System.Drawing.Size(975, 813);
            this.tabPageEquations.TabIndex = 4;
            this.tabPageEquations.Text = "equations";
            this.tabPageEquations.UseVisualStyleBackColor = true;
            // 
            // AdvancedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdvancedControl";
            this.Size = new System.Drawing.Size(983, 842);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageVms.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPageLinux.ResumeLayout(false);
            this.tabControlLinux.ResumeLayout(false);
            this.tabPageMCFToDecodes.ResumeLayout(false);
            this.tabPageQuality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuality)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageEncode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RawDataInput rawDataInput1;
        private ArchiverInput archiverInput1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MathInput mathInput1;
        private DayfileInsert dayfileInsert1;
        private System.Windows.Forms.GroupBox groupBox4;
        private ArchiverFileList archiverFileList1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVms;
        private System.Windows.Forms.TabPage tabPageLinux;
        private System.Windows.Forms.TabPage tabPageQuality;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDownloadQuality;
        private System.Windows.Forms.TextBox textBoxCbttQuality;
        private System.Windows.Forms.DataGridView dataGridViewQuality;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDownloadNessid;
        private System.Windows.Forms.TextBox textBoxNessid;
        private System.Windows.Forms.TextBox textBoxHoursBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlLinux;
        private System.Windows.Forms.TabPage tabPageSites;
        private System.Windows.Forms.TabPage tabPageMCFToDecodes;
        private Mcf2Decodes mcf2Decodes1;
        private System.Windows.Forms.TabPage tabPageEncode;
        private ManualEncodeDecode.EncodeAscii encodeAscii1;
        private System.Windows.Forms.TabPage tabPageEquations;
        private System.Windows.Forms.GroupBox groupBox6;
        private GpFixInflow gpFixInflow1;
    }
}
