using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Database
    {
        Logins Logins;
        Admins Admins;
        Libririans Libririans;
        Students Students;
        Books Books;
        Borrows Borrows;

        public Logins Logins1 { get => Logins; set => Logins = value; }
        public Admins Admins1 { get => Admins; set => Admins = value; }
        public Libririans Libririans1 { get => Libririans; set => Libririans = value; }
        public Students Students1 { get => Students; set => Students = value; }
        public Books Books1 { get => Books; set => Books = value; }
        public Borrows Borrows1 { get => Borrows; set => Borrows = value; }

        public Database()
        {
            Logins = new Logins();
            Admins = new Admins();
            Libririans = new Libririans();
            Students = new Students();
            Books = new Books();
            Borrows = new Borrows();

        }
    }
}
