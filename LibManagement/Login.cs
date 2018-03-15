using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LibManagement
{
    class Login
    {

        EF.LibraryEntities Mydb = new EF.LibraryEntities();

        public string UserName { get; set; }
        public string PassWord { get; set; }


        public static string Question;
        public static string Answer;
        public static string ForgetPAss;


        public bool RegisterAdmin()
        {
            try
            {
                var QSearch = (from R in Mydb.tbl_Register select R.Reg).Single();
                if (QSearch == false)
                    return true;
                else
                    return false;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void UpdateRegister()
        {
            try
            {
                EF.tbl_Register Re = Mydb.tbl_Register.First();
                Re.Reg = true;
                Mydb.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public bool LoginAdmin()
        {
            try
            {
                var QLogin= Mydb.tbl_Login.Where(x=> x.Username== UserName && x.Password==PassWord);
                if (QLogin.Any())
                    return true;
                else
                    return false;
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool SearchAdmin(string User)
        {
            try
            {
                var QSearch = Mydb.tbl_Login.Where(c => c.Username==User).FirstOrDefault();
                if (QSearch == null)
                    return false;
                else
                {
                    Answer = QSearch.Answer;
                    ForgetPAss = QSearch.Password;
                    var QQuestin=Mydb.tbl_Question.Where(c=> c.Id== QSearch.Id).FirstOrDefault();
                    Question = QQuestin.Question;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool UpdatePassword(string User, string OldPass,string NewPass)
        {
            try
            {
                var QUdate = Mydb.tbl_Login.Where(c => c.Username == User && c.Password == OldPass).FirstOrDefault();
                if (QUdate == null)
                    return false;
                else
                {
                    QUdate.Password = NewPass;
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
        
        
    }
}
