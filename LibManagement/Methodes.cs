using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using Telerik.WinControls.UI;

namespace LibManagement
{
    class Methodes
    {

        EF.LibraryEntities Mydb = new EF.LibraryEntities();
        PersianCalendar PC = new PersianCalendar();

        public int BookId { get; set; }
        public int UserId { get; set; }
        public string BorrowDate { get; set; }
        public string returnDate { get; set; }

        static SqlCommand Cmd = new SqlCommand();
        static SqlConnection Con = new SqlConnection();
        static SqlDataAdapter Adp = new SqlDataAdapter();
        static DataTable Dt = new DataTable();

        private static void Connect()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
            }
            catch
            {
            }
        }

        private static void DC()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
            catch
            {
            }
        }

        private static void MakeConnection()
        {
            try
            {
                Con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+Application.StartupPath+@"\Library.mdf;Integrated Security=True;Connect Timeout=30";
                Cmd.Connection = Con;
            }
            catch
            {
            }
        }

        public static bool Backup(string Path)
        {
            try
            {
                DC();
               // Cmd.CommandText = @"Backup DataBase Library To Disk='" + Path + "'";
                Cmd.CommandText = @"USE MASTER BACKUP DATABASE ["+Application.StartupPath+@"\Library.mdf] TO DISK = '" + Path + "' WITH NOFORMAT, NOINIT, NAME = 'Library-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                MakeConnection();
                Connect();
                Cmd.ExecuteNonQuery();
                DC();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static bool Restore(string Path)
        {
            try
            {
                DC();
                Cmd.CommandText = "ALTER DATABASE [" + Application.StartupPath + @"\Library.mdf] SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " USE master " + "RESTORE DATABASE [" + Application.StartupPath + @"\Library.mdf] FROM DISK ='" + Path + "'WITH REPLACE ";
                MakeConnection();
                Connect();
                Cmd.ExecuteNonQuery();
                DC();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool SearchBookID(int Id)
        {
            try
            {
               var QSearchBookID = Mydb.tbl_Books.Where(c => c.Id == Id).Any();
               if (QSearchBookID)
                   return true;
               else
                   return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool SearchUserID(int ID)
        {
            try
            {
                var QSearchUserId = Mydb.tbl_User.Where(c => c.Id == ID).Any();
                if (QSearchUserId)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool AddBoroow()
        {
            try
            {
                var QSearchBorrow = Mydb.tbl_Borrow.Where(c => c.BookId == BookId).Any();
                if (QSearchBorrow)
                    return false;
                else
                {
                    Mydb.tbl_Borrow.Add(new EF.tbl_Borrow()
                    {
                        BookId= BookId,
                        BorrowerId = UserId,
                        BorrowDate = BorrowDate,
                        ReturnDate = returnDate
                    });

                    Mydb.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public object AllBorrow()
        {
            try
            {
                var QAllBorrow =Mydb.tbl_Borrow.Select(c=> new {c.Id,c.BookId,c.BorrowerId,c.tbl_Books.Bookname,c.tbl_User.FName,c.tbl_User.LName}).ToList();
                return QAllBorrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }
        }

        public bool DeleteBorrow(int ID)
        {
            try
            {
                var QDeleteBorrow = Mydb.tbl_Borrow.Where(c => c.Id == ID).FirstOrDefault();
                Mydb.tbl_Borrow.Remove(QDeleteBorrow);
                Mydb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool SearchIdBook(int BookId)
        {
            try
            {
                var QSearchBookID = Mydb.tbl_Borrow.Where(c => c.BookId == BookId).Any();
                if (QSearchBookID)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false; 
            }
        }

        public bool SearchIdUser(int UserID)
        {
            try
            {
                var QSearchUser = Mydb.tbl_Borrow.Where(c => c.BorrowerId == UserID).Any();
                if (QSearchUser)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool Date(string Date1,string Date2)
        {
            try
            {
                string[] FDate = Date1.Split('/');
                string[] SDate = Date2.Split('/');
                if (int.Parse(FDate[1]) > int.Parse(SDate[1]))
                    return true;
                else if (int.Parse(FDate[2]) > int.Parse(SDate[2]))
                    return true;
                else
                    return false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void ReturnBorrow(RadGridView dgv)
        {
            try
            {
              // IEnumerable<DataRow> QueryReturn  =Mydb.tbl_Borrow.Select(c=>new {c.BookId,c.tbl_Books.Bookname,c.ReturnDate}).ToList();
                Cmd.CommandText = "select tbl_Books.Bookname,tbl_Borrow.BookId,tbl_Borrow.ReturnDate from tbl_Borrow,tbl_Books where tbl_Books.Id = tbl_Borrow.BookId";
                MakeConnection();
                Adp.SelectCommand = Cmd;
                Connect();
                Adp.Fill(Dt);
                DC();
                string ReturnDate = "";
                string Now = PC.GetYear(DateTime.Now).ToString() + "/" + PC.GetMonth(DateTime.Now).ToString() + "/" + PC.GetDayOfMonth(DateTime.Now).ToString();
                dgv.Columns.Add("id", "شماره کتاب");
                dgv.Columns.Add("Bookname", "اسم کتاب");
                

                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    ReturnDate = Dt.Rows[i].ItemArray[2].ToString();
                    if (Date(Now, ReturnDate))
                        dgv.Rows.Add(Dt.Rows[i].ItemArray[1].ToString(),Dt.Rows[i].ItemArray[0].ToString()); 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

    }
}
