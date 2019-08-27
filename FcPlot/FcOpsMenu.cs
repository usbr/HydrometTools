using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Reclamation.TimeSeries.Hydromet.Operations;
using Reclamation.TimeSeries;

namespace FcPlot
{
    public partial class FcOpsMenu : Form
    {
        FcPlotUI ui;
        FloodControlPoint pt;
        public FcOpsMenu(FcPlotUI ui)
        {
            InitializeComponent();

            this.ui = ui;
            pt = new FloodControlPoint(ui.comboBoxSite.Text.ToString());
            double maxSpace = pt.TotalUpstreamActiveSpace;
            this.textBoxSpace.Text = maxSpace.ToString("F0");
            string dams = string.Join(", ", pt.UpstreamReservoirs);
            this.textBoxDams.Text = dams;
            string inflowCode = pt.StationQD + " QU";
            this.textBoxInflowCode.Text = inflowCode;
            this.numericUpDownInflowYear.Maximum = (DateTime.Now.Year - 1);
            this.numericUpDownInflowYear.Value = (DateTime.Now.Year - 1);
            string outflowCode = pt.StationQD + " QD";
            this.textBoxOutflowCode.Text = outflowCode;
            this.numericUpDownOutflowYear.Maximum = (DateTime.Now.Year - 1);
            this.numericUpDownOutflowYear.Value = (DateTime.Now.Year - 1);
            this.dateTimePickerCustomOutflow1.Value = DateTime.Now.Date;
            this.dateTimePickerCustomOutflow2.Value = DateTime.Now.Date.AddDays(5);
            this.dateTimePickerCustomOutflow3.Value = DateTime.Now.Date.AddDays(10);
            this.dateTimePickerSimStart.MaxDate = DateTime.Now.Date;
            this.comboBoxEspDay.SelectedItem = this.comboBoxEspDay.Items[1];
            this.comboBoxEspTraces.SelectedItem = this.comboBoxEspTraces.Items[0];
            this.toolStripStatusLabel1.Text = "";
            this.textBoxRfcNode.Text = pt.EspNode;


            // Handle ENTER key press
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            this.numericUpDownInflowYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            this.numericUpDownOutflowYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            this.numericUpDownInflowShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            this.numericUpDownOutflowShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            this.textBoxInflowScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            this.textBoxOutflowScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void Operate()
        {
            ui.hydrometChart1.FcOps(ui, pt, this);
        }

        private void buttonOperate_Click(object sender, EventArgs e)
        {
            Operate();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Operate();
                // Then Do your Thang
            }
        }

        private void checkBoxUseCustomOutflow_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePickerCustomOutflow1.Enabled = checkBoxUseCustomOutflow.Checked;
            this.dateTimePickerCustomOutflow2.Enabled = checkBoxUseCustomOutflow.Checked;
            this.dateTimePickerCustomOutflow3.Enabled = checkBoxUseCustomOutflow.Checked;
            this.textBoxCustomOutflow1.Enabled = checkBoxUseCustomOutflow.Checked;
            this.textBoxCustomOutflow2.Enabled = checkBoxUseCustomOutflow.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonNFcast.Enabled = checkBoxUseCustomInflow.Checked;
            this.radioButtonWSFcast.Enabled = checkBoxUseCustomInflow.Checked;
            this.textBoxRfcNode.Enabled = checkBoxUseCustomInflow.Checked;
            this.comboBoxEspDay.Enabled = checkBoxUseCustomInflow.Checked;
            this.buttonGetEspData.Enabled = checkBoxUseCustomInflow.Checked;
            this.comboBoxEspTraces.Enabled = checkBoxUseCustomInflow.Checked;
        }

        public SeriesList espList;
        public List<string> yearList;

        private void buttonGetEspData_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Downloading ESP data...";
            this.UseWaitCursor = true;
            string rfcURL = @"https://www.nwrfc.noaa.gov/chpsesp/ensemble/";
            if (this.radioButtonNFcast.Checked)
            {
                rfcURL += "natural/";
            }
            else
            {
                rfcURL += "watersupply/";
            }
            rfcURL += this.textBoxRfcNode.Text + ".ESPF" + this.comboBoxEspDay.SelectedItem.ToString() + ".csv";
            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(rfcURL);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string rfcDataString = sr.ReadToEnd();
            
            List<string> rfcData = new List<string>();
            string[] rfcDataRows = rfcDataString.Split('\n');
            //this.labelEspFile.Text = rfcDataRows[0].ToString().Replace("FILE:","");
            //this.labelEspUpdated.Text = rfcDataRows[1].ToString().Replace("ISSUED:", "");
            yearList = rfcDataRows[6].Split(',').ToList();
            int colCount = yearList.Count();
            // Build SeriesList container
            SeriesList sList = new SeriesList();
            for (int i = 1; i < colCount; i++)
            {
                Series s = new Series();
                s.Name = yearList[i].ToString();
                sList.Add(s);
            }
            // Populate Series List
            for (int i = 7; i < rfcDataRows.Count() - 1; i++)
            {
                var rowData = rfcDataRows[i].Split(',');
                var t = DateTime.Parse(rowData[0]);
                for (int j = 1; j < colCount; j++)
                {
                    sList[j - 1].Add(t, Convert.ToDouble(rowData[j]) * 1000.0);
                }

            }
            // Aggregate Series List to Daily
            espList = new SeriesList();
            foreach (var series in sList)
            {
                var s = Reclamation.TimeSeries.Math.DailyAverage(series);
                s.Name = series.Name;
                espList.Add(s);
            }

            FillEspDropDown();
            this.toolStripStatusLabel1.Text = "Downloaded " + rfcDataRows[0].ToString().Replace("FILE:", "") + 
                ". Updated " + rfcDataRows[1].ToString().Replace("ISSUED:", "");
            this.UseWaitCursor = false;
        }

        private void FillEspDropDown()
        {
            this.comboBoxEspTraces.Items.Clear();
            foreach (Series item in espList)
            {
                comboBoxEspTraces.Items.Add(item.Name);
            }
            comboBoxEspTraces.SelectedItem = comboBoxEspTraces.Items[comboBoxEspTraces.Items.Count- 1];
        }

    }
}
