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
    public partial class frmBackup : RadForm
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
                return;
            if (Methodes.Backup(txtPath.Text.Trim()))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show ("پشتیبان گیری با موفقیت انجام شد","پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                txtPath.ResetText();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("خطا در پشتیبان گیری", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog SV = new SaveFileDialog();
            SV.Title = "Save...";
            SV.Filter = "BAK File(*.bak)|*.bak";
           if (SV.ShowDialog() == DialogResult.OK)
           {
               txtPath.Text = SV.FileName;
           }
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
            
        }
    }

