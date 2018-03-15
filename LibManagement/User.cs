using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagement
{
    class User
    {
        EF.LibraryEntities Mydb = new EF.LibraryEntities();

        public string FName { get; set; }
        public string LName { get; set; }
        public string Tell { get; set; }
        public string Pic { get; set; }

        public static string Name;
        public static string Family;
        public static string Phone;
        public static string Picture;
 

        public bool AddUser()
        {
            try
            {
                var QAddUser = Mydb.tbl_User.Add(new EF.tbl_User()
                {
                    FName = FName,
                    LName = LName,
                    Tell = Tell,
                    Pic = Pic
                });

                Mydb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public object AllUser()
        {
            try
            {
                var QAllUser = Mydb.tbl_User.Select(c => new {c.Id,c.FName,c.LName,c.Tell,c.Pic }).ToList();
                return QAllUser;
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
                return "";
            }
        }

        public void DeleteUser(int ID)
        {
            try
            {
                var QDeleteUser = Mydb.tbl_User.Where(c => c.Id == ID).FirstOrDefault();
                Mydb.tbl_User.Remove(QDeleteUser);
                Mydb.SaveChanges();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        public void SearchUser(int ID)
        {
            try
            {
                var QSearch = Mydb.tbl_User.Where(c => c.Id == ID).FirstOrDefault();
                Name = QSearch.FName;
                Family = QSearch.LName;
                Phone = QSearch.Tell;
                Picture = QSearch.Pic;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool EditUser(int Id)
        {
            try
            {
                var QeditUser= Mydb.tbl_User.Where(c=>c.Id==Id).FirstOrDefault();
                QeditUser.FName = FName;
                QeditUser.LName = LName;
                QeditUser.Tell = Tell;
                QeditUser.Pic = Pic;

                Mydb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public object SearchByType(string Type, string str)
        {
            try
            {
                if(Type=="Name")
                {
                    var QSearch = Mydb.tbl_User.Where(c => c.FName.Contains(str)).Select(c => new {c.FName,c.LName,c.Tell,c.Pic }).ToList();
                    return QSearch;
                }
                else
                {
                    var QSearch = Mydb.tbl_User.Where(c => c.LName.Contains(str)).Select(c => new { c.FName, c.LName, c.Tell, c.Pic }).ToList();
                    return QSearch;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                return "";
            }
        }
    }
}
