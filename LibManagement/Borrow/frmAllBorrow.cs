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

namespace LibManagement.Borrow
{
    public partial class frmAllBorrow : RadForm
    {
        public frmAllBorrow()
        {
            InitializeComponent();
        }

        Methodes M = new Methodes();

        private void frmAllBorrow_Load(object sender, EventArgs e)
        {
            dgvAllBorrow.DataSource = M.AllBorrow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new frmBorrow().ShowDialog() == DialogResult.OK)
                frmAllBorrow_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllBorrow.CurrentRow == null)
                return;
            if (dgvAllBorrow.CurrentRow != null)
            {
                int BorrowId = int.Parse(dgvAllBorrow.CurrentRow.Cells[0].Value.ToString());
                RadMessageBox.SetThemeName("Windows8");
                DialogResult dr = RadMessageBox.Show("آیا میخواهید مقدار انتخابی را حذف نمایید ؟؟", "پیغام سیستم", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (M.DeleteBorrow(BorrowId))
                    {
                        RadMessageBox.SetThemeName("Windows8");
                        RadMessageBox.Show("مقدار مورد نظر با موفقیت پاک شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                        frmAllBorrow_Load(null, null);
                    }
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmAllBorrow_Load(null, null);
        }
    }
}
