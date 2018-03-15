using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagement
{
    class Books
    {
        EF.LibraryEntities Mydb = new EF.LibraryEntities();

        public static string Bookname;
        public static string Writer;
        public static string Type;

        public void SearchBook(int BookId)
        {
            try
            {
                var QSearchbook = Mydb.tbl_Books.Where(c => c.Id == BookId).FirstOrDefault();
                Bookname = QSearchbook.Bookname;
                Writer = QSearchbook.Writer;
                var QSearchType = Mydb.tbl_Type.Where(c => c.Id == QSearchbook.Type).FirstOrDefault();
                Type = QSearchType.Type;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public bool AddType(string Type)
        {
            try
            {
                var QSearchType = Mydb.tbl_Type.Where(c => c.Type == Type).FirstOrDefault();
                if (QSearchType != null)
                    return false;
                else
                {
                    var QAddType = Mydb.tbl_Type.Add(new EF.tbl_Type()
                    {
                        Type = Type
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

        public object AllType()
        {
            try
            {
                var QAllType = (from t in Mydb.tbl_Type select new { t.Id, t.Type }).ToList();
                return QAllType;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return "";
            }
        }

        public void AddBook(string Bookname, string Writer, int Type)
        {
            try
            {
                var QAdd = Mydb.tbl_Books.Add(new EF.tbl_Books()
                {
                    Bookname = Bookname,
                    Writer = Writer,
                    Type = Type
                });
                Mydb.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public object AllBook()
        {
            try
            {
                var QAllBook = (from B in Mydb.tbl_Books select new { B.Id, B.Bookname, B.Writer, B.tbl_Type.Type }).ToList();
                return QAllBook;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return "";
            }
        }

        public void DeleteBook(int Id)
        {
            try
            {
                var QDeleteBook = Mydb.tbl_Books.Where(c => c.Id == Id).FirstOrDefault();
                Mydb.tbl_Books.Remove(QDeleteBook);
                Mydb.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void EditBook(int ID, string BookName, string writer, int type)
        {
            try
            {
                var QSearchBook = Mydb.tbl_Books.Where(c => c.Id == ID).FirstOrDefault();
                QSearchBook.Bookname = BookName;
                QSearchBook.Writer = writer;
                QSearchBook.Type = type;

                Mydb.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public object SearchBookByVar(string var, string str)
        {
            try
            {
                if (var == "BookName")
                {
                    var QSearch = Mydb.tbl_Books.Where(c => c.Bookname.Contains(str)).Select(c => new { c.Bookname, c.Writer, c.tbl_Type.Type }).ToList();
                    return QSearch;
                }
                else
                {
                    var QSearch = Mydb.tbl_Books.Where(c => c.Writer.Contains(str)).Select(c => new { c.Bookname, c.Writer, c.tbl_Type.Type }).ToList();
                    return QSearch;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return "";
            }
        }

        public bool DeleteType(int TypeId)
        {
            try
            {
                var QSearchType = Mydb.tbl_Books.Where(c => c.Type == TypeId).Any();
                if (QSearchType)
                    return false;
                else
                {
                    var QDeleteType = Mydb.tbl_Type.Where(c => c.Id == TypeId).FirstOrDefault();
                    Mydb.tbl_Type.Remove(QDeleteType);
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
