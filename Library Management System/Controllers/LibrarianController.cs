using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Models;

namespace Library_Management_System.Controllers
{
    public class LibrarianController
    {

        static Database db = new Database();

        static public void InsertLibrarian(Librarian librarian)
        {

            db.Libririans1.InsertLibrarian( librarian);


        }

        static public List<Librarian> GetLibrarianList()
        {
            List<Librarian> librarianList = db.Libririans1.GetLibrarianList();
            return librarianList;

        }

        static public Librarian GetLibrarian(string id)
        {
            Librarian a = new Librarian();
            a = db.Libririans1.GetLibrarian( id);
            return a;

        }

        static public void UpdateLibrarian(String Id, string name, string salary)
        {

            db.Libririans1.UpdateLibrarian( Id,  name,  salary);


        }

        static public void DeleteLibrarian(string Id)
        {
            db.Libririans1.DeleteLibrarian( Id);


        }

        static public void UpdateLibrarianSelf(String Id, string email, string Phoneno, string address)
        {

            db.Libririans1.UpdateLibrarianSelf(Id,  email,  Phoneno,  address);


        }
    }
}
