using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Borrow
    {
        string id;
        string studentid;
        string bookid;
        DateTime issuedate;
        DateTime returedate;
        string borrowstatus;
        string status;

        public string Id { get => id; set => id = value; }
        public string Studentid { get => studentid; set => studentid = value; }
        public string Bookid { get => bookid; set => bookid = value; }
        public DateTime Issuedate { get => issuedate; set => issuedate = value; }
        public DateTime Returedate { get => returedate; set => returedate = value; }
        public string Borrowstatus { get => borrowstatus; set => borrowstatus = value; }
        public string Status { get => status; set => status = value; }
    }
}
