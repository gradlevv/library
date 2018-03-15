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

namespace LibManagement.Report
{
    public partial class frmUserReport : RadForm
    {
        public frmUserReport()
        {
            InitializeComponent();
        }

        User U = new User();
        DataTable Dt = new DataTable();

        private void frmUserReport_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = U.AllUser();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Dt.Columns.Add("Id");
            Dt.Columns.Add("FName");
            Dt.Columns.Add("LName");
            Dt.Columns.Add("Tell");

            foreach (var row in dgvUsers.Rows)
            {
                Dt.Rows.Add(row.Cells[0].Value,row.Cells[1].Value,row.Cells[2].Value,row.Cells[3].Value);
            }
            stiReport1.RegData("Dt", Dt);
            stiReport1.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
