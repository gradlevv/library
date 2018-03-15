using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.IO;

namespace LibManagement.Users
{
    public partial class frmAddUser : RadForm
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        User M = new User();
        bool temp = false;
        public int ID = 0;

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                btnAdd.Text = "ویرایش";
                M.SearchUser(ID);
                txtName.Text = User.Name;
                txtFamily.Text = User.Family;
                txtTell.Text = User.Phone;
                pictureBox1.ImageLocation = User.Picture;
            }
        }

        private void lklPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Title = "Select....";
            OP.Filter = "JPG (*.jpg)|*.jpg";
            if (OP.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = OP.FileName;
                temp = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtFamily.Text.Trim() == "" || txtTell.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (ID == 0)
            {
                string PicAdr = @"C:\Pic";
                string FullName = txtName.Text.Trim() + txtFamily.Text.Trim() + txtTell.Text.Trim();
                if (!Directory.Exists(PicAdr))
                {
                    Directory.CreateDirectory(PicAdr);
                }
                string Path = @"C:\Pic\" + FullName + ".jpg";
                if (temp)
                    pictureBox1.Image.Save(Path, ImageFormat.Jpeg);
                else
                    Path = Application.StartupPath + @"\\Default-User.jpg";
                M.FName = txtName.Text.Trim();
                M.LName = txtFamily.Text.Trim();
                M.Tell = txtTell.Text.Trim();
                M.Pic = Path;
                if (M.AddUser())
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("کاربر با موفقیت اضافه شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                    pictureBox1.ImageLocation = Application.StartupPath + @"\\Default-User.jpg";
                    temp = false;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string FullName = txtName.Text.Trim() + txtFamily.Text.Trim() + txtTell.Text.Trim();
                string Path = @"C:\Pic\" + FullName + ".jpg";
                if (temp)
                    pictureBox1.Image.Save(Path, ImageFormat.Jpeg);

                M.FName = txtName.Text.Trim();
                M.LName = txtFamily.Text.Trim();
                M.Tell = txtTell.Text.Trim();
                M.Pic = Path;

                if(M.EditUser(ID))
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("ویرایش با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                    pictureBox1.ImageLocation = Application.StartupPath + @"\\Default-User.jpg";
                    temp = false;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtTell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
                e.Handled = true;
        }


    }
}
