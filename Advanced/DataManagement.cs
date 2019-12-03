using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydrometTools.Advanced
{
    public partial class DataManagement : UserControl
    {
        public DataManagement()
        {
            InitializeComponent();
            this.comboBoxTInterval.SelectedIndexChanged += ComboBoxTInterval_SelectedIndexChanged;
            setTimeIntervalOptions();
        }

        private void ComboBoxTInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selInterval = this.comboBoxTInterval.SelectedItem.ToString();
            dateTimePickerT1.Format = DateTimePickerFormat.Custom;
            dateTimePickerT2.Format = DateTimePickerFormat.Custom;
            if (selInterval.ToLower() == "monthly")
            {
                dateTimePickerT1.CustomFormat = "MM-yyyy";
                dateTimePickerT2.CustomFormat = "MM-yyyy";
            }
            else
            {
                dateTimePickerT1.CustomFormat = "MM-dd-yyyy";
                dateTimePickerT2.CustomFormat = "MM-dd-yyyy";
            }
        }

        private void setTimeIntervalOptions()
        {
            this.comboBoxTInterval.Items.Add("Monthly");
            this.comboBoxTInterval.Items.Add("Daily");
            this.comboBoxTInterval.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to recalculate? This will overwrite data in the database...", "Confirm Calculation...", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var db = HydrometTools.Database.DB();
                var selInterval = this.comboBoxTInterval.SelectedItem.ToString();
                var calcSites = new List<string>();
                calcSites.AddRange(this.textBoxSites.Text.Split(',').ToList());
                var calcPCodes = new List<string>();
                calcPCodes.AddRange(this.textBoxPCodes.Text.Split(',').ToList());

                foreach (string site in calcSites)
                {
                    foreach (string pcode in calcPCodes)
                    {
                        if (selInterval.ToLower() == "monthly")
                        {
                            var s = db.GetCalculationSeries(site.Trim(), pcode.Trim(), Reclamation.TimeSeries.TimeInterval.Monthly);
                            s.Calculate(new DateTime(this.dateTimePickerT1.Value.Year, this.dateTimePickerT1.Value.Month, 1),
                                new DateTime(this.dateTimePickerT2.Value.Year, this.dateTimePickerT2.Value.Month, 1));
                        }
                        else
                        {
                            var s = db.GetCalculationSeries(site.Trim(), pcode.Trim(), Reclamation.TimeSeries.TimeInterval.Daily);
                            s.Calculate(this.dateTimePickerT1.Value.Date, this.dateTimePickerT2.Value.Date);
                        }
                    }
                }
            }
        }


    }
}
