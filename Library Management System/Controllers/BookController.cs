using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Models;

namespace Library_Management_System.Controllers
{
    public class BookController
    {
        

            static Database db = new Database();

            static public void InsertBook(Book s)
            {

                db.Books1.InsertBook(s);


            }

            static public List<Book> GetBookList()
            {
                List<Book> bookList = db.Books1.GetBookList();
                return bookList;

            }

            static public Book GetBook(string id)
            {
            Book a = new Book();
                a = db.Books1.GetBook(id);
                return a;

            }

            static public void UpdateBook(String Id, string title, string noofcopy)
            {

                db.Books1.UpdateBook(Id, title, noofcopy);


            }

            static public void DeleteBook(string Id)
            {
                db.Books1.DeleteBook(Id);


            }

           

            static public List<Book> GetBookList1(String name)
            {
                List<Book> bookList = db.Books1.GetBookList1(name);
                return bookList;

            }
        }
}
