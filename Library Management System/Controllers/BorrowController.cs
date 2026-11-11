using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Models;

namespace Library_Management_System.Controllers
{
    public class BorrowController
    {
        static Database db = new Database();

        static public void InsertBorrow(Borrow s)
        {

            db.Borrows1.InsertBorrow(s);


        }

        static public List<Borrow> GetBorrowList()
        {
            List<Borrow> borrowList = db.Borrows1.GetBorrowList();
            return borrowList;

        }

        static public Borrow GetBorrow(string id)
        {
            Borrow a = new Borrow();
            a = db.Borrows1.GetBorrow(id);
            return a;

        }

        static public void Returnborrow(String Id, DateTime returndate)
        {

            db.Borrows1.ReturnBorrow(Id, returndate);


        }

        static public void DeleteBorrow(string Id)
        {
            db.Borrows1.DeleteBorrow(Id);


        }



        static public List<Borrow> GetBorrowList1(String id)
        {
            List<Borrow> borrowList = db.Borrows1.GetBorrowList1(id);
            return borrowList;

        }
    }
}
