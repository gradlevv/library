using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace LibManagement.Borrow
{
    public partial class frmBorrow : RadForm
    {
        public frmBorrow()
        {
            InitializeComponent();
        }

        Methodes M = new Methodes();

        private void btnToday_Click(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            DateTime DT = DateTime.Now;
            txtBorrowDate.Text = PC.GetYear(DT).ToString() + "/" + PC.GetMonth(DT).ToString() + "/" + PC.GetDayOfMonth(DT).ToString();
        }

        private void txtBookID_Leave(object sender, EventArgs e)
        {
            if (M.SearchBookID(int.Parse(txtBookID.Text.Trim())))
                txtBookID.BackColor = Color.Green;
            else
                txtBookID.BackColor = Color.Red;
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (M.SearchUserID(int.Parse(txtUserId.Text.Trim())))
                txtUserId.BackColor = Color.Green;
            else
                txtUserId.BackColor = Color.Red;
         
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            DateTime DT = DateTime.Now;
            int AddDay = DT.Day - 10;
            if(AddDay>0)
                txtReturnDate.Text = PC.GetYear(DT).ToString() + "/" + PC.GetMonth(DT.AddMonths(1)).ToString() + "/" + PC.GetDayOfMonth(DT.AddDays(10)).ToString();
            else
                txtReturnDate.Text = PC.GetYear(DT).ToString() + "/" + PC.GetMonth(DT).ToString() + "/" + PC.GetDayOfMonth(DT.AddDays(10)).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text.Trim() == "" || txtUserId.Text.Trim() == "" || txtBorrowDate.Text.Trim() == "" || txtReturnDate.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تمام مقادیر را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return ;
            }

            if ( txtUserId.BackColor == Color.Red  || txtBookID.BackColor == Color.Red)
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("شماره کاربر یا شماره کتاب در بانک موجود نیست", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            M.BookId =int.Parse(txtBookID.Text.Trim());
            M.UserId =int.Parse(txtUserId.Text.Trim());
            M.BorrowDate = txtBorrowDate.Text.Trim();
            M.returnDate = txtReturnDate.Text.Trim();

            if (M.AddBoroow())
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("امانت با موفقیت ثبت شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                DialogResult = DialogResult.OK;
                
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("کتاب قبلا به امانت گرفته شده است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookID.Text.Trim() == "")
                txtBookID.BackColor = Color.Empty;
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            if (txtUserId.Text.Trim() == "")
                txtUserId.BackColor = Color.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
                e.Handled = true;
        }

    }
}
