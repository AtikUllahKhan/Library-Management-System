using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Book
    {
        string id;
        string title;
        string author;
        string edition;
        string type;
        string isbn;
        string noofcopy;
        string bookshelf;
        string publication;
        string status;

        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Edition { get => edition; set => edition = value; }
        public string Type { get => type; set => type = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Noofcopy { get => noofcopy; set => noofcopy = value; }
        public string Bookshelf { get => bookshelf; set => bookshelf = value; }
        public string Publication { get => publication; set => publication = value; }
        public string Status { get => status; set => status = value; }
    }
}
