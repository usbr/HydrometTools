using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Reclamation.Core;

namespace HydrometTools.Reports
{
    public partial class OpsLog : UserControl
    {
        private static DataTable opsLogItems;

        public OpsLog()
        {
            InitializeComponent();
            this.labelUser.Text = "User: " + Environment.UserName.ToLower();
            this.dateTimePickerT1.Value = DateTime.Now.AddDays(-3);
            this.dateTimePickerT2.Value = DateTime.Now;

            // Populate Basin drop-down
            var dropDownItems = GetOpsLogOptions();
            var basinItems = dropDownItems.DefaultView.ToTable(true, "basin");
            var basinStrings = basinItems.Rows.Cast<DataRow>()
                    .Select(row => row["basin"].ToString())
                    .ToArray();
            comboBoxBasin.Items.AddRange(basinStrings);
            this.comboBoxBasin.SelectedIndexChanged += ComboBoxBasin_SelectedIndexChanged;
            comboBoxBasin.SelectedIndex = 0;

            // Populate entries in the ops log
            UpdateLogTable();
        }

        private void ComboBoxBasin_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProject.Items.Clear();
            var selectedBasin = this.comboBoxBasin.SelectedItem;
            var projectItems = opsLogItems.Select("basin = '" + selectedBasin + "'");
            foreach (var item in projectItems)
            {
                comboBoxProject.Items.Add(item["project"]);
            }
            comboBoxProject.SelectedIndex = comboBoxProject.Items.Count - 1;
        }

        static DataTable GetOpsLogOptions()
        {
            var fRef = FileUtility.GetFileReference("opslogitems.csv");
            opsLogItems = new CsvFile(fRef);
            return opsLogItems;
        }

        private void buttonRefreshLog_Click(object sender, EventArgs e)
        {
            UpdateLogTable();
            //MessageBox.Show("Not yet implemented... Need DB access...", "Refresh Log Display", MessageBoxButtons.OK);
        }

        private void UpdateLogTable()
        {
            string basin = "", project = "";
            if (checkBoxFilterLogEntries.Checked)
            {
                basin = this.comboBoxBasin.SelectedItem.ToString();
                project = this.comboBoxProject.SelectedItem.ToString();
            }
            var tbl = Database.GetOpsLogEntries(this.dateTimePickerT1.Value, this.dateTimePickerT2.Value, basin, project);
            this.dataGridView1.DataSource = tbl;
        }

        private void buttonSaveEntry_Click(object sender, EventArgs e)
        {
            Database.InsertOpsLogEntry(Environment.UserName.ToLower(), this.textBoxLogEntry.Text,
                this.comboBoxBasin.SelectedItem.ToString(), this.comboBoxProject.SelectedItem.ToString());
            //MessageBox.Show("User: " + Environment.UserName.ToLower() + Environment.NewLine
            //    + "Basin: " + this.comboBoxBasin.SelectedItem + Environment.NewLine
            //    + "Project: " + this.comboBoxProject.SelectedItem + Environment.NewLine
            //    + "Log Entry: " + this.textBoxLogEntry.Text + Environment.NewLine
            //    + "Not yet implemented... Need DB access...", "Save Log Entry", MessageBoxButtons.OK);
            UpdateLogTable();
        }

        private void buttonExportLogs_Click(object sender, EventArgs e)
        {
            // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            // Select all the cells
            dataGridView1.SelectAll();
            // Copy selected cells to DataObject
            DataObject dataObject = dataGridView1.GetClipboardContent();
            // Get temp filename
            var fName = System.IO.Path.GetTempFileName().Replace("tmp","csv");
            // Get the text of the DataObject, and serialize it to a file
            File.WriteAllText(fName, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
            // Open file
            System.Diagnostics.Process.Start(fName);
        }
    }
}
