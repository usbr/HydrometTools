using System;
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
            string dams =string.Join(", ", pt.UpstreamReservoirs);
            this.textBoxDams.Text = dams;
            string inflowCode = pt.StationQD + " QU";
            this.textBoxInflowCode.Text = inflowCode;
            this.textBoxInflowYears.Text = (DateTime.Now.Year - 1).ToString("F0");
            this.numericUpDownInflowYear.Maximum = (DateTime.Now.Year - 1);
            this.numericUpDownInflowYear.Value = (DateTime.Now.Year - 1);
            string outflowCode = pt.StationQD + " QD";
            this.textBoxOutflowCode.Text = outflowCode;
            this.textBoxOutflowYears.Text = (DateTime.Now.Year - 1).ToString("F0");
            this.numericUpDownOutflowYear.Maximum = (DateTime.Now.Year - 1);
            this.numericUpDownOutflowYear.Value = (DateTime.Now.Year - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ui.hydrometChart1.FcOps(ui, this.textBoxInflowCode.Text, this.textBoxOutflowCode.Text,
                this.numericUpDownInflowYear.Value.ToString(), this.numericUpDownOutflowYear.Value.ToString(),
                //this.textBoxInflowYears.Text, this.textBoxOutflowYears.Text, 
                pt.UpstreamReservoirs);
        }
    }
}
