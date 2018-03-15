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
    public partial class frmSetting : RadForm
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        Login L = new Login();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim()==""|| txtPassword.Text.Trim() == "" || txtNewPass.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if(L.UpdatePassword(txtUsername.Text.Trim(),txtPassword.Text.Trim(),txtNewPass.Text.Trim()))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("تغییرات با موفقیت اعمال شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("نام کاربری یا کلمه عبور اشتباه است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
