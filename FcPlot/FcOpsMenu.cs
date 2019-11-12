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
            int maxYear = DateTime.Now.Year - 1;
            if (DateTime.Now.Month > 9)
            {
                maxYear = DateTime.Now.Year;
            }
            this.numericUpDownInflowYear.Maximum = maxYear;
            this.numericUpDownInflowYear.Value = maxYear;
            string outflowCode = pt.StationQD + " QD";
            this.textBoxOutflowCode.Text = outflowCode;
            this.numericUpDownOutflowYear.Maximum = maxYear;
            this.numericUpDownOutflowYear.Value = maxYear;
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
            this.comboBoxEspTraces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

            // Add tooltips
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 200;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.checkBoxRedrawGraph, "Unchecking this will allow you to graph multiple scenario curves on the chart");
            toolTip1.SetToolTip(this.checkBoxUseCustomInflow, "Checking this will allow you to download and use RFC ESP inflows");
            toolTip1.SetToolTip(this.checkBoxUseCustomOutflow, "Checking this will allow you to use your own outflow schedule");
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
            this.dateTimePickerSimStart.Value = this.dateTimePickerSimStart.MaxDate;
            this.dateTimePickerSimStart.Enabled = !checkBoxUseCustomOutflow.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonNFcast.Enabled = checkBoxUseCustomInflow.Checked;
            this.radioButtonWSFcast.Enabled = checkBoxUseCustomInflow.Checked;
            this.textBoxRfcNode.Enabled = checkBoxUseCustomInflow.Checked;
            this.comboBoxEspDay.Enabled = checkBoxUseCustomInflow.Checked;
            this.buttonGetEspData.Enabled = checkBoxUseCustomInflow.Checked;
            this.comboBoxEspTraces.Enabled = checkBoxUseCustomInflow.Checked;
            this.dateTimePickerSimStart.Value = this.dateTimePickerSimStart.MaxDate;
            this.dateTimePickerSimStart.Enabled = !checkBoxUseCustomInflow.Checked;
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
            // Create statistical Series
            var sMin = new Series("MIN");
            var sMax = new Series("MAX");
            var sAvg = new Series("AVG");
            var sP10 = new Series("P10");
            var sP25 = new Series("P25");
            var sP50 = new Series("P50");
            var sP75 = new Series("P75");
            var sP90 = new Series("P90");
            foreach (Point pt in espList[0])
            {
                DateTime ithT = pt.DateTime;
                List<double> ithVals = new List<double>();
                foreach (Series s in espList)
                {
                    ithVals.Add(s[ithT].Value);
                }
                sMin.Add(ithT, ithVals.Min());
                sAvg.Add(ithT, ithVals.Average());
                sMax.Add(ithT, ithVals.Max());
                ithVals.Sort();
                sP10.Add(ithT, ithVals[Convert.ToInt32(System.Math.Floor(ithVals.Count * 0.10))]);
                sP25.Add(ithT, ithVals[Convert.ToInt32(System.Math.Floor(ithVals.Count * 0.25))]);
                sP50.Add(ithT, ithVals[Convert.ToInt32(System.Math.Floor(ithVals.Count * 0.50))]);
                sP75.Add(ithT, ithVals[Convert.ToInt32(System.Math.Floor(ithVals.Count * 0.75))]);
                sP90.Add(ithT, ithVals[Convert.ToInt32(System.Math.Floor(ithVals.Count * 0.90))]);
            }
            yearList.AddRange(new List<string> { "MIN", "P10", "P25", "P50", "P75", "P90", "MAX", "AVG" });
            espList.Add(new SeriesList() { sMin, sP10, sP25, sP50, sP75, sP90, sMax, sAvg });

            // Finalize
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
