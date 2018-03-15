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

namespace LibManagement.Users
{
    public partial class frmUsers : RadForm
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        User U = new User();
        Methodes Me = new Methodes();
        string SearchType = "";

        private void frmUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = U.AllUser();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new frmAddUser().ShowDialog() == DialogResult.OK)
                frmUsers_Load(null, null);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
                return;
            if (dgvUsers.CurrentRow != null)
            {
                int id = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                RadMessageBox.SetThemeName("Windows8");
                DialogResult dr = RadMessageBox.Show("آیا میخواهید کاربر انتخاب شده را حذف نمایید؟", "پیغام سیستم", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (Me.SearchIdUser(id))
                    {
                        RadMessageBox.SetThemeName("Windows8");
                        RadMessageBox.Show("کاربر کتاب به امانت گرفته است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                        return;
                    }
                    else
                    {
                        U.DeleteUser(id);
                        RadMessageBox.SetThemeName("Windows8");
                        RadMessageBox.Show("کاربر با موفقیت حذف شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                        frmUsers_Load(null, null);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
                return;
            if (dgvUsers.CurrentRow != null)
            {
                int id = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                if (new frmAddUser() { ID = id }.ShowDialog() == DialogResult.OK)
                    frmUsers_Load(null, null);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdbName.Checked)
            {
                SearchType = "Name";
               dgvUsers.DataSource= U.SearchByType(SearchType, txtSearch.Text.Trim());
            }
            else
            {
                SearchType= "Family";
                dgvUsers.DataSource = U.SearchByType(SearchType, txtSearch.Text.Trim());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgvUsers_CellClick(object sender, GridViewCellEventArgs e)
        {
            string Path = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            pictureBox1.ImageLocation = Path;
        }


    }
}
