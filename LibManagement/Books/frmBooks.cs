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

namespace LibManagement
{
    public partial class frmBooks : RadForm
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        Books M = new Books();
        Methodes Me = new Methodes();
        string var = "";

        private void frmBooks_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = M.AllBook();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new frmAddBook().ShowDialog() == DialogResult.OK)
                frmBooks_Load(null, null);
            
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            new frmAddType().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
                return;
            if (dgvBooks.CurrentRow != null)
            {
                int Id = int.Parse(dgvBooks.CurrentRow.Cells[0].Value.ToString());
                RadMessageBox.SetThemeName("Windows8");
                DialogResult dr = RadMessageBox.Show("آیا میخواهید کتاب انتخاب شده را حذف نمایید؟", "پیغام سیستم", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (Me.SearchIdBook(Id))
                    {
                        RadMessageBox.SetThemeName("Windows8");
                        RadMessageBox.Show("کتاب امانت داده شده است!", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                        return;
                    }
                    else
                    {
                        M.DeleteBook(Id);
                        frmBooks_Load(null, null);
                        RadMessageBox.SetThemeName("Windows8");
                        RadMessageBox.Show("کتاب با موفقیت حذف شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
                return;
            else
            {
                int Id = int.Parse(dgvBooks.CurrentRow.Cells[0].Value.ToString());
                if (new frmAddBook() {id=Id }.ShowDialog() == DialogResult.OK)
                    frmBooks_Load(null, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmBooks_Load(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdbBookName.Checked)
            {
                var = "BookName";
               dgvBooks.DataSource=M.SearchBookByVar(var,txtSearch.Text.Trim());
            }
            else
            {
                var = "BookWriter";
                dgvBooks.DataSource = M.SearchBookByVar(var, txtSearch.Text.Trim());
            }
        }

        private void rdbBookWriter_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void rdbBookName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }


    }
}
