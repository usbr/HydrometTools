using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Reclamation.Core;
using Reclamation.TimeSeries;
using Reclamation.TimeSeries.Hydromet;
using Reclamation.TimeSeries.Analysis;
using Math = Reclamation.TimeSeries.Math;
using Reclamation.TimeSeries.Forms.Graphing;
using System.IO;

namespace HydrometTools.SnowGG
{
    public partial class SnowGG : UserControl
    {
        public SnowGG()
        {
            InitializeComponent();
            this.comboBoxCbtt.Text = UserPreference.Lookup("Snowgg->cbtt");
            this.comboBoxPcode.Text = UserPreference.Lookup("Snowgg->pcode");
            
            // 
            // timeSeriesGraph1
            // 
            this.timeSeriesGraph1 = new Reclamation.TimeSeries.Graphing.TimeSeriesTeeChartGraph();
            this.timeSeriesGraph1.AnnotationOnMouseMove = false;
            this.timeSeriesGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeSeriesGraph1.GraphSettings = new GraphSettings(); 
            this.timeSeriesGraph1.Location = new System.Drawing.Point(0, 131);
            this.timeSeriesGraph1.Margin = new System.Windows.Forms.Padding(4);
            this.timeSeriesGraph1.MissingDataValue = -999D;
            this.timeSeriesGraph1.MonthlySummaryMultiYear = false;
            this.timeSeriesGraph1.MultiLeftAxis = false;
            this.timeSeriesGraph1.Name = "timeSeriesGraph1";
            this.timeSeriesGraph1.Size = new System.Drawing.Size(732, 296);
            this.timeSeriesGraph1.SubTitle = "";
            this.timeSeriesGraph1.TabIndex = 1;
            this.timeSeriesGraph1.Title = "";
            this.Controls.Remove(this.panel1);
            this.tabPageChart.Controls.Add(this.timeSeriesGraph1);
            this.Controls.Add(this.panel1);


            Reset();
            this.timeSeriesGraph1.AfterEditGraph += timeSeriesGraph1_AfterEditGraph;
            timeSeriesGraph1.AnnotationOnMouseMove = true;
        }

        void timeSeriesGraph1_AfterEditGraph(object sender, EventArgs e)
        {
            var gs = GetGraphSettings();
            gs.Merge(timeSeriesGraph1.GraphSettings);
            gs.Save(GraphSettingFileName());

        }

        void Reset()
        {
            
            var t = DateTime.Now;
            int wy = t.Year;
            if( t.Month >= 10)
                wy++;

            this.yearSelector1.SelectedYears = new Int32[]{wy--,wy};
            var t2 = t.AddMonths(1);


            //if (t.Month == 9)
            //{
            //    this.monthRangePicker1.MonthDayRange = new MonthDayRange(10, 1, 9, 30);
            //}
            //else
            //{
            //    this.monthRangePicker1.MonthDayRange = new MonthDayRange(10, 1, t2.Month, DateTime.DaysInMonth(t2.Year, t2.Month));
            //}
            this.monthRangePicker1.MonthDayRange = new MonthDayRange(10, 1, 9, 30);

            //this.comboBoxPcode.SelectedIndex = 0;
            this.checkBoxGP.Visible = HydrometInfoUtility.HydrometServerFromPreferences() == HydrometHost.GreatPlains;
        }

        private List<string> snowGgColors = new List<string> {
            "Blue",
            "ForestGreen",
            "Fuchsia",
            "DarkRed",
            "LimeGreen",
            "GoldenRod",
            "Aqua",
            "SlateGray",
            "DarkSalmon",
            "Peru"
        };

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                timeSeriesGraph1.AnnotationOnMouseMove = checkBoxAnnotate.Checked;
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                string pcodeOrig = DeterminePcode();

                timeSeriesGraph1.Clear();

                string cbttOrig = comboBoxCbtt.Text.Trim();
                string cbtt = cbttOrig, pcode = pcodeOrig;

                var seriesList = new List<string>();
                if ((cbttOrig.Trim() == "" || pcodeOrig.Trim() == "") && textBoxMultiple.Text == "")
                {
                    return;
                }
                else
                {
                    if (!checkBoxUseList.Checked)
                    {
                        UserPreference.Save("Snowgg->cbtt", cbttOrig);
                        UserPreference.Save("Snowgg->pcode", comboBoxPcode.Text.Trim());
                        seriesList.Add(cbttOrig + "_" + pcodeOrig);
                    }
                    else
                    {
                        var seriesItems = textBoxMultiple.Text.Split(',');
                        foreach (string item in seriesItems)
                        {
                            if (item.Trim().Split(' ').Length == 2)
                            {
                                seriesList.Add(item.Trim().Split(' ')[0] + "_" + item.Trim().Split(' ')[1]);
                            }
                        }
                    }
                }

                int[] waterYears = this.yearSelector1.SelectedYears;
                SeriesList finalSeriesCollection = new SeriesList();
                foreach (string series in seriesList)
                {
                    cbtt = series.Split('_')[0];
                    comboBoxCbtt.Text = cbtt;
                    pcode = series.Split('_')[1];
                    comboBoxPcode.Text = pcode;
                    var server = HydrometInfoUtility.HydrometServerFromPreferences();
                    var range = monthRangePicker1.MonthDayRange;

                    Series s;
                    if (this.checkBoxUseInstant.Checked)
                    {
                        s = new HydrometInstantSeries(cbtt, pcode, server);
                    }
                    else
                    {
                        s = new HydrometDailySeries(cbtt, pcode, server);
                    }
                    var sl = new SeriesList();
                    sl.Add(s);

                    // get wy data
                    var wyList = new SeriesList();
                    if (cySelected)
                    {
                        wyList = PiscesAnalysis.WaterYears(sl, waterYears, false, 1, true);
                    }
                    else
                    {
                        wyList = PiscesAnalysis.WaterYears(sl, waterYears, false, 10, true);
                    }

                    foreach (Series item in wyList)
                    {
                        item.Name = cbtt + " " + pcode;  
                        // remove missing data points
                        var missingItems = item.Table.Select("value = 998877");
                        foreach (var row in missingItems)
                        {
                            item.RemoveAt(item.IndexOf(Convert.ToDateTime(row.ItemArray[0])));
                        }
                    }

                    // apply deltas and add stats if toggled
                    wyList = ApplyDeltas(wyList, waterYears);
                    AddStatistics(wyList);

                    if (checkBoxGP.Checked)
                    {
                        GPAverage(cbtt, server, range, wyList);
                    }

                    // remove months outside selected range
                    var list = FilterBySelectedRange(range, wyList);
                    finalSeriesCollection.Add(list);
                }

                // Set series line colors
                var uniqueSeriesNames = new List<string>();
                var uniqueSeriesColors = new List<string>();
                int colorCounter = 0;
                foreach (var item in finalSeriesCollection)
                {
                    // set line color by year which is identified in the legendtext field
                    if (!uniqueSeriesNames.Contains(item.Appearance.LegendText) && !item.Appearance.LegendText.Contains("%") && 
                        !item.Appearance.LegendText.Contains("avg") && !item.Appearance.LegendText.Contains("max") && !item.Appearance.LegendText.Contains("min"))
                    {
                        uniqueSeriesNames.Add(item.Appearance.LegendText);//.Name);
                        uniqueSeriesColors.Add(snowGgColors[colorCounter]);
                        colorCounter = (colorCounter + 1) % snowGgColors.Count;
                    }
                }
                foreach (var item in finalSeriesCollection)
                {
                    try
                    {
                        int colIdx = uniqueSeriesNames.IndexOf(item.Appearance.LegendText);//.Name);
                        item.Appearance.Color = uniqueSeriesColors[colIdx];
                    }
                    catch
                    {
                        item.Appearance.Color = "SlateGray"; //System.Drawing.KnownColor.SlateGray                  
                    }
                }

                this.timeSeriesGraph1.AnalysisType = AnalysisType.WaterYears;
                this.timeSeriesGraph1.Series = finalSeriesCollection;
                if (seriesList.Count == 1)
                {
                    this.timeSeriesGraph1.Title = HydrometInfoUtility.LookupSiteDescription(cbtt) + "  Elevation:" + HydrometInfoUtility.LookupElevation(cbtt);
                }
                //timeSeriesGraph1.GraphSettings = GetGraphSettings();

                this.timeSeriesGraph1.Draw(true);

                comboBoxCbtt.Text = cbttOrig;
                comboBoxPcode.Text = pcodeOrig;

                timeSeriesGraph1.GraphSettings = GetGraphSettings();
                this.dataGridView1.DataSource = this.timeSeriesGraph1.Series.ToDataTable(true);
                this.dataGridView1.Columns[0].DefaultCellStyle.Format = "MMM-d";
                this.linkLabelReport.Visible = true;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string GraphSettingFileName()
        {
            return Path.Combine(FileUtility.GetTempPath(), "hydromet_graph.txt");
        }
        GraphSettings GetGraphSettings()
        {
            GraphSettings gs = new GraphSettings();

            var fn = GraphSettingFileName();

            if (File.Exists(fn))
                gs.Read(fn);
            return gs;
        }

        private SeriesList ApplyDeltas(SeriesList wyList, int[] waterYears)
        {
            int sCount = wyList.Count;
            if (checkBoxDeltas.Checked && sCount > 1)
            {
                var deltaList = new SeriesList();
                Series s1 = wyList[0];
                s1.RemoveMissing();
                deltaList.Add(s1);

                for (int sIdx = 1; sIdx < sCount; sIdx++)
                {
                    var ithS = wyList[sIdx];
                    var deltaS = new Series();
                    var deltaNoZeroS = new Series();
                    int deltaCounter = 0;
                    for (int ptIdx = 1; ptIdx < ithS.Count; ptIdx++)
                    {
                        if (ithS[ptIdx].DateTime < s1.MaxDateTime)
                        {
                            deltaS.Add(ithS[ptIdx].DateTime,double.NaN);
                            deltaNoZeroS.Add(ithS[ptIdx].DateTime, double.NaN);
                        }
                        else if (ithS[ptIdx].DateTime == s1.MaxDateTime)
                        {
                            deltaS.Add(s1[ithS[ptIdx].DateTime]);
                            deltaNoZeroS.Add(s1[ithS[ptIdx].DateTime]);
                        }
                        else if (ithS[ptIdx].DateTime > s1.MaxDateTime)
                        {
                            // Filter out projected zeros but keep the running negatives in terms of calculating the evolving
                            //  delta-differenced values
                            var calcVal = deltaS[deltaCounter - 1].Value + ithS[ptIdx].Value - ithS[ptIdx - 1].Value;
                            deltaS.Add(ithS[ptIdx].DateTime, calcVal);
                            if (calcVal < 0)
                            {
                                deltaNoZeroS.Add(ithS[ptIdx].DateTime, 0);
                            }
                            else
                            {
                                deltaNoZeroS.Add(ithS[ptIdx].DateTime, calcVal);
                            }                            
                        }
                        deltaCounter++;
                    }
                    deltaNoZeroS.Units = s1.Units;
                    deltaNoZeroS.Name = waterYears[sIdx].ToString("F0") + " deltas";
                    // [JR] Displays original data in addition to delta curves
                    //wyList.Add(deltaS);
                    // [JR] Only shows delta curves
                    deltaList.Add(deltaNoZeroS);
                }
                return deltaList;
            }
            else
            {
                return wyList;
            }
        }

        private void AddStatistics(SeriesList wyList)
        {

            bool anyStats = checkBoxMax.Checked || checkBoxMin.Checked || checkBoxAvg.Checked || checkBoxPctls.Checked;

            if (!anyStats)
                return;

            int y1 = DateTime.Now.Date.AddYears(-30).Year;
            int y2 = DateTime.Now.Date.Year;
            int[] pctls = new int[] { };

            int.TryParse(this.textBoxWY1.Text, out y1);
            int.TryParse(this.textBoxWY2.Text, out y2);

            if (checkBoxPctls.Checked)
            {
                try
                {
                    string values = textBoxPctls.Text;
                    string[] tokens = values.Split(',');
                    pctls = Array.ConvertAll<string, int>(tokens, int.Parse);
                }
                catch
                {
                    pctls = new int[] { 10, 50, 90 };
                }

            }


            DateTime t1, t2;
            if (cySelected)
            {
                t1 = new DateTime(y1, 1, 1);
                t2 = new DateTime(y2, 12, 31);
            }
            else
            {
                t1 = new DateTime(y1 - 1, 10, 1);
                t2 = new DateTime(y2, 9, 30);
            }

            var server = HydrometInfoUtility.HydrometServerFromPreferences();
            Series s;
            if (this.checkBoxUseInstant.Checked)
            {
                s = new HydrometInstantSeries(comboBoxCbtt.Text.Trim(), DeterminePcode(), server);
            }
            else
            {
                s = new HydrometDailySeries(comboBoxCbtt.Text.Trim(), DeterminePcode(), server);
            }
            s.Read(t1, t2);
            s.RemoveMissing();
            s.Appearance.LegendText = "";

            YearRange yr;
            if (cySelected)
            {
                yr = new YearRange(2000, 1);
            }
            else
            {
                yr = new YearRange(2000, 10);
            }
            var list = Math.SummaryHydrograph(s, pctls, yr.DateTime1, checkBoxMax.Checked, checkBoxMin.Checked, checkBoxAvg.Checked, false); //, false);
           
            
            wyList.Add(list);

        }

        private static SeriesList FilterBySelectedRange(MonthDayRange range, SeriesList wyList)
        {
            SeriesList list = new SeriesList();
            foreach (Series item in wyList)
            {
                //// bug fix: leap years shifted to year 2000
                ////          have extra data point in October of next year.
                ////          delete this.
                //if (item.Count > 0 && item[0].DateTime.Month == 10
                //    && item[item.Count - 1].DateTime.Month == 10
                //    && range.Month2 != 10)
                //{
                //    item.ReadOnly = false;
                //    item.RemoveAt(item.Count - 1);

                //}

                list.Add(Math.ShiftToYear( Math.Subset(item, range),2000));

            }

            return list;
        }

        private static void GPAverage(string cbtt, HydrometHost server, MonthDayRange range, SeriesList wyList)
        {
            var se_avg = new HydrometDailySeries(cbtt, "se_avg", server);
            var sl2 = new SeriesList();
            sl2.Add(se_avg);
            var list1 = PiscesAnalysis.WaterYears(sl2, new int[] { 2002 }, false, range.Month1, true);
            if (list1.Count == 1)
            {
                var se = list1[0];
                se.Appearance.LegendText = "SE_AVG";
                wyList.Add(se);
            }
        }


        private string DeterminePcode()
        {
            string rval = "se";
            string input = comboBoxPcode.Text.ToLower().Trim();

            

            if (input.StartsWith("snow", StringComparison.CurrentCultureIgnoreCase))
            {

                if (HydrometInfoUtility.ArchiveParameterExists(comboBoxCbtt.Text.Trim().ToUpper(), "SE"))
                    rval = "se";
                else if (HydrometInfoUtility.ArchiveParameterExists(comboBoxCbtt.Text.Trim().ToUpper(), "SP"))
                    rval = "sp";
            }
            else
            if (input.StartsWith("flow", StringComparison.CurrentCultureIgnoreCase))
            {
                rval = "qd";
            }
            else if( input.StartsWith("stor", StringComparison.CurrentCultureIgnoreCase) )
            {
                rval = "af";
            }
            else if (input.StartsWith("prec", StringComparison.CurrentCultureIgnoreCase))
            {
                rval = "pu";
            }
            else
            {
                rval = input;
            }
            return rval;
        }

        

        private void SnowGG_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonSelectGroup_Click(object sender, EventArgs e)
        {
            var dlg = new SelectBasin(SnowGGUtility.GetSnowggGroupList());

            dlg.ShowDialog();
            // get group name.
            string grp = dlg.SelectedGroup;
            string pcode = "se";
            if (grp.ToLower().IndexOf("dams") != 0)
            {
                pcode = "af";
            }
            if (grp.Trim() != "")
            {
                //this.buttonSelectGroup.Text = grp;
                comboBoxCbtt.Items.Clear();
                // get list of items.

                string[] list = SnowGGUtility.GetCbttList(grp);

                for (int i = 0; i < list.Length; i++)
                {
                    // check if first itme is 'pcode:pc'
                    if (i == 0)
                    {// set pcode
                        if (list[0].IndexOf("pcode:") == 0)
                        {
                            this.comboBoxPcode.Text = list[i].Substring(6);
                        }
                        else
                        {
                            this.comboBoxPcode.Text = pcode;
                        }
                    }
                    // add other items to cbtt combo box
                    comboBoxCbtt.Items.Add(list[i]);


                }
                comboBoxCbtt.SelectedIndex = 0;
            }
        }

        private void comboBoxCbtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRefresh_Click(this, EventArgs.Empty);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (comboBoxCbtt.SelectedIndex < comboBoxCbtt.Items.Count - 1)
            {
                comboBoxCbtt.SelectedIndex++;
            }
        }

        private void SnowGG_VisibleChanged(object sender, EventArgs e)
        {
           // if (Visible == true)
               // Reset();
        }

        private void useList_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCbtt.Enabled = !comboBoxCbtt.Enabled;
            comboBoxPcode.Enabled = !comboBoxPcode.Enabled;
            textBoxMultiple.Enabled = !textBoxMultiple.Enabled;
            checkBoxSumList.Enabled = !checkBoxSumList.Enabled;
        }

        private bool cySelected = false;
        private void buttonToggleMonths_Click(object sender, EventArgs e)
        {
            var startMonth = this.monthRangePicker1.BeginningMonth;
            var selectedRange = this.monthRangePicker1.MonthDayRange;
            if (startMonth == 1)
            {
                this.monthRangePicker1.BeginningMonth = 10;
                this.buttonToggleMonths.Text = "Use CY";
                selectedRange = new MonthDayRange(10, 1, 9, 30);
                cySelected = false;
            }
            else
            {
                this.monthRangePicker1.BeginningMonth = 1;
                this.buttonToggleMonths.Text = "Use WY";
                selectedRange = new MonthDayRange(1, 1, 12, 31);
                cySelected = true;
            }
            this.monthRangePicker1.Update();
            this.monthRangePicker1.MonthDayRange = selectedRange;

        }

        private void linkLabelReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fn = FileUtility.GetTempFileName(".csv");
            CsvFile.WriteToCSV(this.timeSeriesGraph1.Series.ToDataTable(true), fn);
            System.Diagnostics.Process.Start(fn);
        }
    }
}
