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
    public partial class frmAddType : RadForm
    {
        public frmAddType()
        {
            InitializeComponent();
        }

        Books M = new Books();

        private void frmAddType_Load(object sender, EventArgs e)
        {
            dgvType.DataSource = M.AllType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtadd.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا نام موضوع را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (M.AddType(txtadd.Text.Trim()))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("موضوع با موفقیت اضافه شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                frmAddType_Load(null,null);
                txtadd.ResetText();
                
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("نام موضوع تکراری می باشد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvType.CurrentRow == null)
                return;
            if (dgvType.CurrentRow != null)
            {
                int ID =int.Parse(dgvType.CurrentRow.Cells[0].Value.ToString());
                if (M.DeleteType(ID))
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("موضوع با موفقیت حذف شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                    frmAddType_Load(null, null);
                    return;
                }
                else
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("موضوع انتخاب شده قابل پاک شدن نمی باشد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
            }
        }


    }
}
