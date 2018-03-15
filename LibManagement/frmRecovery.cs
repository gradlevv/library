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
    public partial class frmRecovery : RadForm
    {
        public frmRecovery()
        {
            InitializeComponent();
        }

        Login M = new Login();

        private void frmRecovery_Load(object sender, EventArgs e)
        {
            lblQuestin.Text = Login.Question;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Trim() == Login.Answer)
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show(" کلمه عبور شما" + Login.ForgetPAss, "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("جواب اشتباه است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
