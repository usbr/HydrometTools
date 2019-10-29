using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydrometTools.Reports
{
    public partial class OpsLog : UserControl
    {
        public OpsLog()
        {
            InitializeComponent();
            this.labelUser.Text = "User: " + Environment.UserName.ToLower();
            this.dateTimePickerT1.Value = DateTime.Now.AddDays(-3);
            this.dateTimePickerT2.Value = DateTime.Now;
        }

        private void buttonRefreshLog_Click(object sender, EventArgs e)
        {
            var tbl =  Database.GetOpsLogEntries(this.dateTimePickerT1.Value, this.dateTimePickerT2.Value);
            this.dataGridView1.DataSource = tbl;

        }
    }
}
