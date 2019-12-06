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
            this.dateTimePickerT1.Value = DateTime.Now.Date.AddDays(-10);
            this.dateTimePickerT2.Value = DateTime.Now.Date.AddDays(1).AddMinutes(-1);
            
            // Populate entries in the ops log
            UpdateLogTable();
            this.dataGridView1.CellClick += DataGridView1_CellClick;
            
            // Populate drop-downs
            var dropDownItems = GetOpsLogOptions();
            var basinItems = dropDownItems.DefaultView.ToTable(true, "basin");
            var basinStrings = basinItems.Rows.Cast<DataRow>()
                    .Select(row => row["basin"].ToString())
                    .ToArray();
            comboBoxBasin.Items.AddRange(basinStrings);
            this.comboBoxBasin.SelectedIndexChanged += ComboBoxBasin_SelectedIndexChanged;
            comboBoxBasin.SelectedIndex = 0;
            this.comboBoxColumns.Items.Add("All");
            foreach (DataColumn col in ((DataTable)this.dataGridView1.DataSource).Columns)
            {
                if (col.DataType == typeof(string))
                {
                    this.comboBoxColumns.Items.Add(col.ColumnName);
                }
            }
            this.comboBoxColumns.SelectedIndex = 0;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
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
        }

        private void UpdateLogTable()
        {
            string basin = "", project = "";
            if (checkBoxFilterLogBasin.Checked)
            {
                basin = this.comboBoxBasin.SelectedItem.ToString();
            }
            if (checkBoxFileterLogProject.Checked)
            {
                project = this.comboBoxProject.SelectedItem.ToString();
            }
            string keyWd = "", colName = "";
            if (checkBoxLogSearch.Checked)
            {
                keyWd = this.textBoxKeyword.Text;
                colName = this.comboBoxColumns.SelectedItem.ToString();
            }
            var tbl = Database.GetOpsLogEntries(this.dateTimePickerT1.Value, this.dateTimePickerT2.Value, basin, project, keyWd, colName);
            this.dataGridView1.DataSource = tbl;

            // format attachment column
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.ForeColor = Color.Blue;
            cellStyle.SelectionForeColor = Color.Black;
            cellStyle.Font = new Font(this.dataGridView1.Font.FontFamily, this.dataGridView1.Font.Size, FontStyle.Underline);
            this.dataGridView1.Columns[dataGridView1.ColumnCount - 1].DefaultCellStyle = cellStyle;

            // format other columns
            this.dataGridView1.Columns["logdate"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Columns["logdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns["logentry"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Columns["logentry"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["attachmentname"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Columns["attachmentname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            // clear log-entries
            this.textBoxLogEntry.Text = "";
            hasAttachment = false;
            this.labelAttachmentPath.Text = "";
            this.labelAttachmentSize.Text = "";
            this.labelAttachmentPath.Visible = hasAttachment;
            this.labelAttachmentSize.Visible = hasAttachment;
        }

        private void buttonSaveEntry_Click(object sender, EventArgs e)
        {
            if (textBoxLogEntry.Text.Length > 0)
            {
                var t = DateTime.Now;
                if (hasAttachment)
                {
                    Database.InsertOpsLogEntry(t, Environment.UserName.ToLower(), this.textBoxLogEntry.Text,
                        this.comboBoxBasin.SelectedItem.ToString(), this.comboBoxProject.SelectedItem.ToString(),
                        this.labelAttachmentName.Text, this.labelAttachmentPath.Text);
                }
                else
                {
                    Database.InsertOpsLogEntry(t, Environment.UserName.ToLower(), this.textBoxLogEntry.Text,
                        this.comboBoxBasin.SelectedItem.ToString(), this.comboBoxProject.SelectedItem.ToString());
                }
                UpdateLogTable();
            }
            else
            {
                MessageBox.Show("Log Entry cannot be blank...", "Log Error", MessageBoxButtons.OK);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if the attachment-name column is checked
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(dataGridView1.ColumnCount - 1) && e.RowIndex != -1)
            {
                // download and open attachment if there is a filename associated with the log entry
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value.ToString() != "")
                {
                    var logId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    var attName = dataGridView1.CurrentCell.Value.ToString();
                    var attachmentBytes = Database.GetOpsLogAttachment(logId);

                    var tempFileName = Path.GetTempPath() + attName;
                    System.IO.File.WriteAllBytes(tempFileName, attachmentBytes);
                    System.Diagnostics.Process.Start(tempFileName);
                }
            }
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
            var fName = System.IO.Path.GetTempFileName().Replace("tmp", "csv");
            // Get the text of the DataObject, and serialize it to a file
            File.WriteAllText(fName, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
            // Open file
            System.Diagnostics.Process.Start(fName);
        }

        bool hasAttachment = false;
        private void buttonAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Find your attachment";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                labelAttachmentPath.Text = dlg.FileName;
                labelAttachmentName.Text = System.IO.Path.GetFileName(dlg.FileName);

                // check and validate attachment
                long len = new System.IO.FileInfo(dlg.FileName).Length;
                var fSize = len / 1024.0 / 1024.0;
                string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                int order = 0;
                while (len >= 1024 && order < sizes.Length - 1)
                {
                    order++;
                    len = len / 1024;
                }
                // check file-size
                double maxSize = 5.0;
                if (fSize > maxSize)
                {
                    MessageBox.Show("(" + String.Format("{0:0.##} {1}", len, sizes[order]) + ") File too large - limit attachments to " + maxSize.ToString("F0") + " MB..."
                        , "Attachment Error", MessageBoxButtons.OK);
                    hasAttachment = false;
                }
                else
                {
                    labelAttachmentSize.Text = "(" + String.Format("{0:0.##} {1}", len, sizes[order]) + ")";
                    hasAttachment = true;
                }
                // check path length
                if (dlg.FileName.Length > 248)
                {
                    MessageBox.Show("Path to file is too long - relocate file and try again...", "Attachment Error", MessageBoxButtons.OK);
                    hasAttachment = false;
                }

                this.labelAttachmentPath.Visible = hasAttachment;
                this.labelAttachmentSize.Visible = hasAttachment;
            }
        }

        private void checkBoxLogSearch_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxKeyword.Enabled = this.checkBoxLogSearch.Checked;
            this.comboBoxColumns.Enabled = this.checkBoxLogSearch.Checked;
        }
    }
}

