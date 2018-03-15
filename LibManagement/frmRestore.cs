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
    public partial class frmRestore : RadForm
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Title = "Choose Bak files...";
            OP.Filter = "BAK File(*.bak)|*.bak";
            if (OP.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = OP.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
                return;
            if (Methodes.Restore(txtPath.Text.Trim()))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("پیغام سیستم", "بازیابی اطلاعات با موفقیت انجام شد", MessageBoxButtons.OK, RadMessageIcon.Info);
                txtPath.ResetText();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("پیغام سیستم", "خطا در بازیابی اطلاعات", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
