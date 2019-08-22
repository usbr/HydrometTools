﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reclamation.TimeSeries.Hydromet.Operations;

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
            this.textBoxCustomOutflow1.Text = "-99";
            this.textBoxCustomOutflow2.Text = "-99";
            this.dateTimePickerSimStart.MaxDate = DateTime.Now.Date;


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
    }
}