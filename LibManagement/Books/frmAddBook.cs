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
    public partial class frmAddBook : RadForm
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        Books M = new Books();
        public int id = 0;

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            cmbGenre.DataSource = M.AllType();

            if (id != 0)
            {
                M.SearchBook(id);
                txtName.Text = Books.Bookname;
                txtWriter.Text = Books.Writer;
                cmbGenre.Text = Books.Type;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtWriter.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (id == 0)
            {
                M.AddBook(txtName.Text.Trim(), txtWriter.Text.Trim(), (int)cmbGenre.SelectedValue);
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("کتاب با موفقیت اضافه شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                DialogResult = DialogResult.OK;
                txtName.Clear();
                txtWriter.Clear();
            }
            else
            {
                
                M.EditBook(id, txtName.Text.Trim(), txtWriter.Text.Trim(),(int)cmbGenre.SelectedValue);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
