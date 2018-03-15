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
    public partial class frmLogin : RadForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Login M = new Login();
        public string UserName = "";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (M.RegisterAdmin())
            {
                new frmFLogin().ShowDialog();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            M.UserName = txtUsername.Text.Trim();
            M.PassWord = txtPassword.Text.Trim();
            if (M.LoginAdmin())
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("ورود با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                UserName = txtUsername.Text.Trim();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("نام کاربری  یا کلمه عبور اشتباه است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا نام کاربری را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if(M.SearchAdmin(txtUsername.Text.Trim()))
            {
                new frmRecovery().ShowDialog();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("کاربری با این نام وجود ندارد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }
    }
}
