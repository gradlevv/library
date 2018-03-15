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
    public partial class frmBorrowReport : RadForm
    {
        public frmBorrowReport()
        {
            InitializeComponent();
        }

        Methodes ME = new Methodes();
        DataTable Dt = new DataTable();

        private void frmBorrowReport_Load(object sender, EventArgs e)
        {
            dgvAllBorrow.DataSource =ME.AllBorrow();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            Dt.Columns.Add("BookId");
            Dt.Columns.Add("BorrowerID");
            Dt.Columns.Add("Bookname");
            Dt.Columns.Add("FName");
            Dt.Columns.Add("LName");

            foreach (var  row in dgvAllBorrow.Rows)
            {
                Dt.Rows.Add(row.Cells[1].Value,row.Cells[2].Value,row.Cells[3].Value,row.Cells[4].Value,row.Cells[5].Value);
            }

            stiReport.RegData("Dt",Dt);
            stiReport.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
