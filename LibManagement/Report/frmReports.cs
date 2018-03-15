using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace LibManagement.Report
{
    public partial class frmReports : RadForm
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnReportShow_Click(object sender, EventArgs e)
        {
            if (rdbUserReport.Checked)
                new frmUserReport().ShowDialog();
            if (rdbBorrowReport.Checked)
                new frmBorrowReport().ShowDialog();
            if (rdbBookReport.Checked)
                new frmBookReport().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
