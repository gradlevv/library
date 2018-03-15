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
    public partial class frmFLogin : RadForm
    {
        public frmFLogin()
        {
            InitializeComponent();
        }

        EF.LibraryEntities Mydb = new EF.LibraryEntities();
        Login M = new Login();

        private void frmFLogin_Load(object sender, EventArgs e)
        {
            cmbSecQuestion.DataSource = Mydb.tbl_Question.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtPConfirm.Text.Trim() == "" || txtAnswer.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("پیغام سیستم", "لطفا تمام مقادیر خواسته شده را وارد نمایید", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (txtPassword.Text.Trim() != txtPConfirm.Text.Trim())
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("پیغام سیستم", "مقادیر رمز عبور با هم برابر نیستند", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }

            Mydb.tbl_Login.Add(new EF.tbl_Login()
            {
               Username=txtUsername.Text.Trim(),
               Password= txtPassword.Text.Trim(),
               QuestionId = cmbSecQuestion.SelectedIndex,
               Answer = txtAnswer.Text.Trim()
            });

            Mydb.SaveChanges();
            M.UpdateRegister();
            RadMessageBox.SetThemeName("Windows8");
            RadMessageBox.Show("مدیر با موفقیت اضافه شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
            Application.Restart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
