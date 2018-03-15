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

namespace LibManagement
{
    public partial class frmMain : RadForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        EF.LibraryEntities Mydb = new EF.LibraryEntities();
        Methodes ME =new Methodes();
        PersianCalendar PC = new PersianCalendar();

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin Lo = new frmLogin();

            Lo.ShowDialog();
            if (Lo.DialogResult != DialogResult.OK)
                this.Close();
            if (Lo.DialogResult == DialogResult.OK)
                lblUser.Text = Lo.UserName;
            LoadForm();
            ME.ReturnBorrow(dgvBorrower);
            analogClockControl1.AutomaticMode = true;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new Users.frmUsers().ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new frmBooks().ShowDialog();
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            new Borrow.frmAllBorrow().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName("Windows8");
            DialogResult dr = RadMessageBox.Show("آیا میخواهید خارج شوید ؟","پیغام سیستم",MessageBoxButtons.YesNo,RadMessageIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btnUsersReport_Click(object sender, EventArgs e)
        {
            new Report.frmUserReport().ShowDialog();
        }

        private void btnBooksreport_Click(object sender, EventArgs e)
        {
            new Report.frmBookReport().ShowDialog();
        }

        private void btnBorrrowReport_Click(object sender, EventArgs e)
        {
            new Report.frmBorrowReport().ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            new frmBackup().ShowDialog();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            new frmRestore().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new frmSetting().ShowDialog();
        }

        private void LoadForm()
        {
            try
            {
                lblDate.Text = PC.GetYear(DateTime.Now).ToString() + "/" + PC.GetMonth(DateTime.Now).ToString() + "/" + PC.GetDayOfMonth(DateTime.Now).ToString();
                var QUserCount = Mydb.tbl_User.Select(c=>c.Id);
                var QBookCount = Mydb.tbl_Books.Select(c => c.Id);
                lblUsersCount.Text = QUserCount.Count().ToString();
                lblBooksCount.Text = QBookCount.Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}
