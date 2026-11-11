using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.Models;

namespace Library_Management_System.Controllers
{
    public class AdminController
    {
        static Database db = new Database();

        static public dynamic getAdmin(string userid)
        {

            var obj = db.Admins1.GetAdmin(userid);
            return obj;

        }

     

        static public void UpdateAdmin(String Id, string email, string Phoneno, string address)
        {
            db.Admins1.UpdateAdmin( Id, email,  Phoneno,  address);

        }
    }
}
