﻿using System;
using System.Windows.Forms;
using Reclamation.Core;
//using FcPlot;
using System.Drawing;
using Reclamation.TimeSeries;
using Reclamation.TimeSeries.Hydromet;
using System.Collections.Generic;
using Reclamation.TimeSeries.Hydromet.Operations;

namespace FcPlot
{
    public partial class FcPlotUI : UserControl
    {
        int[] optionalPercents;
        private bool compilePublic = Convert.ToBoolean(Reclamation.Core.UserPreference.Lookup("CompilePublic"));
        public HydrometHost HydrometServer;

        public FcPlotUI()
        {
            InitializeComponent();
            optionalPercents = new int[] { };  
            // Show targets by default from Jan-Jul
            if (DateTime.Now.Month <= 7)
            {
                this.showTarget.Checked = true;
            }
            if (compilePublic)
            {
                this.checkBoxDashed.Visible = false;
                this.checkBoxOverrideFcast.Visible = false;
                this.showTarget.Visible = false;
                this.showGreenLines.Visible = false;
                this.textBoxOverrideFcast.Visible = false;
                this.textBoxTargetPercentages.Visible = false;
                this.buttonOpsMenu.Visible = false;
                this.tabControl1.Controls.Remove(this.tabPageReport);
            }
            HydrometServer = HydrometInfoUtility.HydrometServerFromPreferences();
        }

        public void Reset()
        {
            if (DesignMode)
                return;
            var t = DateTime.Now;
            int wy = t.Year;
            if (t.Month >= 10)
                wy++;
            this.textBoxWaterYear.Text = wy.ToString();
            var t2 = t.AddMonths(1);

            this.monthRangePicker1.MonthDayRange = new MonthDayRange(10, 1, 9, 30);

            // load QU locations
            this.comboBoxSite.Items.Clear();
            HydrometServer = HydrometInfoUtility.HydrometServerFromPreferences();
            if (HydrometInfoUtility.HydrometServerFromPreferences() == HydrometHost.GreatPlains)
            {
                this.comboBoxSite.Items.AddRange(FcPlotDataSet.GetNames("GP"));
            }
            else
            {
                this.comboBoxSite.Items.AddRange(FcPlotDataSet.GetNames("PN"));
            }

            checkBoxDashed.Visible = false;
        }
       

        private void FcPlotUI_Load(object sender, EventArgs e)
        {
            Reset();
        }


        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOpsMenuOpen();
            GraphData(true);
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GraphData();
        }


        ResidualForecast residForecast;
        ResidualForecast residForecastCompare;


        public void GraphData(bool showFlows = false)
        {
            linkLabelReport.Visible = false;
            if (comboBoxSite.Text.ToString() == "" || this.comboBoxSite.SelectedItem.ToString().IndexOf("--") != -1)
                return;
            try
            {
                optionalPercents = ParseOptionalPercentages();
                Series alternateRequiredContent = new Series();
                Series alternateActualContent = new Series();
                Series actualContent = new Series();
                Series requiredContent = new Series();
                SeriesList targets = new SeriesList();
                SeriesList hmList = new SeriesList();
                SeriesList hmList2 = new SeriesList();
                SeriesList ruleCurves = new SeriesList();
                var cache = new HydrometDataCache();
                var cbttList = new List<string>();
                var cbttListAlternate = new List<string>();
                var labelDates = new List<DateTime>();
                bool showRuleCurve = true;
                Reclamation.TimeSeries.Hydromet.HydrometHost svr;
                var hydSvr = UserPreference.Lookup("HydrometServer");
                if (hydSvr.ToLower() == "greatplains")
                {
                    svr = HydrometHost.GreatPlains;
                }
                else
                {
                    svr = HydrometHost.PNLinux;
                }
                

                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                FloodControlPoint pt = new FloodControlPoint(this.comboBoxSite.Text.ToString());

                if (compilePublic)
                {
                    pt.StationFC = "NA";
                    pt.StationQU = "NA";
                    pt.RequiredLegend = "Full Storage";
                    showRuleCurve = false;
                }

                if (pt.DailyStationQU == "NA")
                {
                    return;
                }
                if (showFlows)
                {
                    this.pcodeInitial.Text = (pt.ResOpsInflow + "," + pt.ResOpsOutflow).ToLower();
                    hydrometChart1.SetRightLabels("Flows (cfs)");
                }

                checkBoxDashed.Visible = pt.StationFC.ToLower() == "heii";

                residForecast = new ResidualForecast(pt,checkBoxDashed.Checked);
                residForecastCompare = new ResidualForecast(pt,checkBoxDashed.Checked);

                DateRange requiredRange = GetRequiredRange();
                DateRange curveRange = GetRuleCurveRange();
                DateRange alternateRange = GetComparisonRange();

                //setup cache for required               
                cbttList.AddRange(residForecast.DailyCbttPcodeList());
                if (this.pcodeInitial.Text.Length >= 1 && this.textBoxWaterYear.Text.Length >= 1)
                {
                    cbttList.AddRange(OptionalCbttList(this.pcodeInitial.Text));
                }
                cache.Add(cbttList.ToArray(), requiredRange.DateTime1.AddDays(-1), requiredRange.DateTime2.AddDays(1), svr, TimeInterval.Daily);
                cache.Add(residForecast.MonthlyCbttPcodeList(), requiredRange.DateTime1, requiredRange.DateTime2, svr, TimeInterval.Monthly);
                
                // setup cache for alternate range
                if (alternateRange.IsValid)
                {
                    cbttListAlternate.AddRange(residForecast.DailyCbttPcodeList());
                    if (this.pcodeComparison.Text.Length >= 1)
                    {
                        cbttListAlternate.AddRange(OptionalCbttList(this.pcodeComparison.Text));
                    }
                    cache.Add(cbttListAlternate.ToArray(), alternateRange.DateTime1.AddDays(-1), alternateRange.DateTime2.AddDays(1), svr, TimeInterval.Daily);
                    cache.Add(residForecast.MonthlyCbttPcodeList(), alternateRange.DateTime1.AddDays(-1), alternateRange.DateTime2.AddDays(1), svr, TimeInterval.Monthly);
                }
                
                //add cache
                HydrometDailySeries.Cache = cache;
                HydrometMonthlySeries.Cache = cache;

                //compute residual forecast
                residForecast.Compute(requiredRange.DateTime1, requiredRange.DateTime2, svr);
                requiredContent = -residForecast.SpaceRequired + pt.TotalUpstreamActiveSpace;
                actualContent = residForecast.TotalContent;
                requiredContent.Name = this.textBoxWaterYear.Text;
                actualContent.Name = this.textBoxWaterYear.Text + " Actual";

                if (this.pcodeInitial.Text.Length >= 1)
                {
                    hmList = ReadHydrometOptionalData(Convert.ToInt32(this.textBoxWaterYear.Text), this.pcodeInitial.Text, requiredRange);
                }

                //compute comparison year residual forecast
                if (alternateRange.IsValid)
                {
                    residForecastCompare.Compute(alternateRange.DateTime1, alternateRange.DateTime2, svr);
                    alternateRequiredContent = -residForecastCompare.SpaceRequired + pt.TotalUpstreamActiveSpace;
                    alternateRequiredContent.Name = this.textBoxAlternateWaterYear.Text;
                    alternateActualContent = residForecastCompare.TotalContent;
                    alternateActualContent.Name = this.textBoxAlternateWaterYear.Text + " Actual";
                    if (this.pcodeComparison.Text.Length >= 1)
                    {
                        hmList2 = ReadHydrometOptionalData(Convert.ToInt32(this.textBoxAlternateWaterYear.Text), this.pcodeComparison.Text, alternateRange);
                        hmList.AddRange(hmList2);
                    }
                }

                if (showGreenLines.Checked == true && !compilePublic) // display flood rule curves for various forecast levels
                {
                    showRuleCurve = true;
                    // Green lines
                    if (residForecast.RuleCurve.FillType == FillType.Fixed)
                    {
                        ruleCurves =  residForecast.RuleCurve.CalculateFixedRuleCurve(curveRange.DateTime1, curveRange.DateTime2,pt.TotalUpstreamActiveSpace);
                        labelDates.Add(curveRange.DateTime1);
                    }
                    else
                    {
                        ruleCurves = residForecast.RuleCurve.CalculateVariableRuleCurves(curveRange.DateTime1, curveRange.DateTime2, pt.TotalUpstreamActiveSpace, pt.PercentSpace / 100.0);
                        labelDates.AddRange(FcPlotDataSet.GetVariableForecastLabelDates(residForecast.RuleCurve.CurveName));
                    }
                }
                else
                {
                    showRuleCurve = false;
                }
                hydrometChart1.SetLabels(pt.Name, "Storage Content (acre-feet)");
                                
                bool dashedLines = checkBoxDashed.Checked && pt.StationFC.ToLower() == "heii";

                // DEFAULT - Plots daily storage content data
                if (!checkBoxShowInstantAF.Checked && !checkBoxShowElevation.Checked)
                {
                    hydrometChart1.Fcplot(residForecast.TotalContent, requiredContent, alternateRequiredContent,
                     alternateActualContent, ruleCurves, labelDates.ToArray(), pt.RequiredLegend, hmList, showRuleCurve,
                      dashedLines);

                    //compute the targets
                    if (pt.FillType == FillType.Variable && (showTarget.Checked == true || checkBoxOverrideFcast.Checked == true))
                    {
                        if (Convert.ToInt32(this.textBoxWaterYear.Text) == DateTime.Now.WaterYear())
                        {
                            actualContent.RemoveMissing();
                            var startPt = actualContent[actualContent.Count - 1];
                            targets = FloodOperation.ComputeTargets(pt, Convert.ToInt32(this.textBoxWaterYear.Text), startPt,
                                optionalPercents, checkBoxDashed.Checked, this.checkBoxOverrideFcast.Checked, this.textBoxOverrideFcast.Text);
                            var aColors = new Color[] { Color.Black, Color.Maroon, Color.Indigo, Color.DarkSlateGray, Color.SaddleBrown };
                            for (int i = 0; i < targets.Count; i++)
                            {
                                var s = targets[i];
                                var c = Color.Black;
                                if (i < aColors.Length)
                                    c = aColors[i];
                                hydrometChart1.CreateTarget(c, s.Name, s, "left");
                                // Add target to datatable
                                residForecast.AddColumnToReportTable(s);
                            }
                        }
                    }
                }
                else
                {
                    string leftPcode = "af";;
                    if (this.checkBoxShowElevation.Checked)
                    {
                        leftPcode = "fb";
                        hydrometChart1.SetLabels(pt.Name, "Water Level Elevation (feet)");

                        if (alternateRange.IsValid)
                        {
                            var sAlternate = new Series();
                            if (checkBoxShowInstantAF.Checked)
                            {
                                sAlternate = new HydrometInstantSeries(pt.UpstreamReservoirs[0], leftPcode, svr);
                            }
                            else
                            {
                                sAlternate = new HydrometDailySeries(pt.UpstreamReservoirs[0], leftPcode, svr);
                            }
                            sAlternate.Read(alternateRange.DateTime1, alternateRange.DateTime2);
                            sAlternate.Name = this.textBoxAlternateWaterYear.Text + " Actual";
                            sAlternate.Units = residForecast.TotalContent.Units;
                            alternateActualContent = sAlternate;
                        }
                    }

                    if (pt.UpstreamReservoirs.Length == 1)
                    {
                        var s = new Series();
                        if (checkBoxShowInstantAF.Checked)
                        {
                            var sInstant = new HydrometInstantSeries(pt.UpstreamReservoirs[0], leftPcode, svr);
                            s = sInstant;
                        }
                        else
                        {
                            var sDaily = new HydrometDailySeries(pt.UpstreamReservoirs[0], leftPcode, svr);
                            s = sDaily;
                        }
                        s.Read(residForecast.TotalContent.MinDateTime, residForecast.TotalContent.MaxDateTime.AddDays(1));
                        s.Name = residForecast.TotalContent.Name;
                        s.Units = residForecast.TotalContent.Units;

                        hydrometChart1.Fcplot(s, requiredContent, alternateRequiredContent,
                        alternateActualContent, ruleCurves, labelDates.ToArray(), pt.RequiredLegend, hmList, showRuleCurve,
                         dashedLines, checkBoxShowElevation.Checked);
                    }
                }

                linkLabelReport.Visible = true;
                labelFlagLegend.Text = pt.FlagLegend;
                dataGridView1.DataSource = residForecast.ReportTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            Cursor = Cursors.Default;
        }


        private int[] ParseOptionalPercentages()
        {
            var txt = textBoxTargetPercentages.Text;
            txt = txt.Replace(",", " ");
            var x = txt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rval = new List<int>();
            int v;
            for (int i = 0; i < x.Length; i++)
            {
                if( int.TryParse(x[i],out v))
                {
                    rval.Add(v);
                }
            }

            return rval.ToArray();
        }


        private string[] OptionalCbttList(string input)
        {
            string[] s = input.ToUpper().Split(',');
            for (int i = 0; i < s.Length; i++)
			{
                s[i] = s[i].TrimStart().TrimEnd();
			}
            return s;
        }


        private static SeriesList ReadHydrometOptionalData(int wy, string query, DateRange range)
        {
            SeriesList rval = new SeriesList();

            string[] tokens = query.Split(',');

            foreach (var pair in tokens)
            {
                var s = pair.TrimStart().TrimEnd();
                string cbtt = s.Split(' ')[0];
                string pcode = s.Split(' ')[1];
                Series hm = new HydrometDailySeries(cbtt,pcode);
                hm.Name = Convert.ToString(wy)+" "+cbtt.ToUpper() + " " + pcode.ToUpper();
                DateTime t1 = range.DateTime1;
                DateTime t2 = range.DateTime2;
                hm.Read(t1, t2);
                hm.RemoveMissing();
                if (hm.Count > 0)
                {
                    rval.Add(hm);
                }
            }

            return rval;
        }


        private DateRange GetRequiredRange()
        {
            DateTime t1 = DateTime.Now;
            DateTime t2 = DateTime.Now;
            int yr = Convert.ToInt32(textBoxWaterYear.Text);
            SetupDates(yr, ref t1, ref t2, false);
            return new DateRange(t1, t2);
        }


        private DateRange GetComparisonRange()
        {
            DateTime t1 = DateTime.Now;
            DateTime t2 = DateTime.Now;
            if (textBoxAlternateWaterYear.Text.Trim() == "")
                return new DateRange(); // invalid
            int yr = Convert.ToInt32(textBoxAlternateWaterYear.Text);
            SetupDates(yr, ref t1, ref t2, true);
            return new DateRange(t1, t2);
        }


        private DateRange GetRuleCurveRange()
        {
            DateTime t1 = DateTime.Now;
            DateTime t2 = DateTime.Now;
            int yr = Convert.ToInt32(textBoxWaterYear.Text);
            SetupDates(yr, ref t1, ref t2,true);
            return new DateRange(t1, t2);
        }


        public void SetupDates(int yr, ref DateTime t1, ref DateTime t2, bool allowFutureDate)
        {
            
            var range = monthRangePicker1.MonthDayRange;

            if (monthRangePicker1.MonthDayRange.Month1 > 9)
                t1 = new DateTime(yr - 1, range.Month1, range.Day1);
            else
                t1 = new DateTime(yr, range.Month1, range.Day1);

            if (monthRangePicker1.MonthDayRange.Month2 > 9)
                t2 = new DateTime(yr - 1, range.Month2, range.Day2);
            else
                t2 = new DateTime(yr, range.Month2, range.Day2);


            if (t2 >= DateTime.Now.Date && !allowFutureDate)
                t2 = DateTime.Now.Date.AddDays(-1);
        }


        public DateTime GetWyEnd(DateTime t)
        {
            var wyEnd = t;
            if (t.Month >= 9)
            {
                wyEnd = new DateTime(t.Year + 1, 10, 30);
            }
            else
            {
                wyEnd = new DateTime(t.Year, 10, 30);
            }
            return wyEnd;
        }


        private void linkLabelReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var fn = FileUtility.GetTempFileName(".csv");
            CsvFile.WriteToCSV(residForecast.ReportTable, fn);
            
            System.Diagnostics.Process.Start(fn);
        }


        FcOpsMenu fcOpsMenu;
        private void buttonOpsMenu_Click(object sender, EventArgs e)
        {
            // Check if a valid FloodControl object is selected and if the form is already open
            if (this.comboBoxSite.SelectedItem == null || this.comboBoxSite.SelectedItem.ToString().IndexOf("--") != -1)
            {
                return;
            }
            CheckOpsMenuOpen();
            // Open form
            fcOpsMenu = new FcOpsMenu(this);
            fcOpsMenu.Show();
        }


        private void CheckOpsMenuOpen()
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == "Flood Control Operations Menu")
                {
                    frm.Close();
                    break;
                }
            }
        }

        private void comboBoxSite_DropDown(object sender, EventArgs e)
        {
            HydrometServer = HydrometInfoUtility.HydrometServerFromPreferences();
            this.comboBoxSite.Items.Clear();
            // load QU locations
            if (HydrometInfoUtility.HydrometServerFromPreferences() == HydrometHost.GreatPlains)
            {
                this.comboBoxSite.Items.AddRange(FcPlotDataSet.GetNames("GP"));
            }
            else
            {
                this.comboBoxSite.Items.AddRange(FcPlotDataSet.GetNames("PN"));
            }
        }
    }
}
