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
    public partial class frmBookReport : RadForm
    {
        public frmBookReport()
        {
            InitializeComponent();
        }

        Books B = new Books();
        DataTable Dt = new DataTable();

        private void frmBookReport_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = B.AllBook();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Dt.Columns.Add("Id");
            Dt.Columns.Add("BookName"); 
            Dt.Columns.Add("Writer");
            Dt.Columns.Add("Genre");

            foreach(var row in dgvBooks.Rows)
            {
                Dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
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
