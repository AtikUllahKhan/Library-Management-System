using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace Library_Management_System.Models
{
    public class Books
    {
        public void InsertBook(Book s)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO book VALUES(@id,@title,@author,@edition,@type,@isbn,@noofcopy,@bookshelf,@publication,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", s.Id);
            cmd.Parameters.AddWithValue("@title", s.Title);
            cmd.Parameters.AddWithValue("@author", s.Author);
            cmd.Parameters.AddWithValue("@edition", s.Edition);
            cmd.Parameters.AddWithValue("@type", s.Type);
            cmd.Parameters.AddWithValue("@isbn", s.Isbn);
            cmd.Parameters.AddWithValue("@noofcopy", s.Noofcopy);
            cmd.Parameters.AddWithValue("@bookshelf", s.Bookshelf);
            cmd.Parameters.AddWithValue("@publication", s.Publication);
            cmd.Parameters.AddWithValue("@status", s.Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Book> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Book> list = new List<Book>();
            using (reader)
            {

                while (reader.Read())
                {
                    Book obj = new Book();
                    obj.Id = reader.GetString(0);
                    obj.Title = reader.GetString(1);
                    obj.Author = reader.GetString(2);
                    obj.Edition = reader.GetString(3);
                    obj.Type = reader.GetString(4);
                    obj.Isbn = reader.GetString(5);
                    obj.Noofcopy = reader.GetString(6);
                    obj.Bookshelf = reader.GetString(7);
                    obj.Publication = reader.GetString(8);
                    obj.Status = reader.GetString(9);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Book GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Book obj = new Book();
            using (reader)
            {
                while (reader.Read())
                {

                    obj.Id = reader.GetString(0);
                    obj.Title = reader.GetString(1);
                    obj.Author = reader.GetString(2);
                    obj.Edition = reader.GetString(3);
                    obj.Type = reader.GetString(4);
                    obj.Isbn = reader.GetString(5);
                    obj.Noofcopy = reader.GetString(6);
                    obj.Bookshelf = reader.GetString(7);
                    obj.Publication = reader.GetString(8);
                    obj.Status = reader.GetString(9);


                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Book> GetBookList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from book WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Book> bookList = GetData(cmd);
            return bookList;


        }

        public Book GetBook(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from book WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Book lib = new Book();
            lib = GetData1(cmd);

            return lib;


        }


        public void DeleteBook(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE book SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateBook(String Id, string title, string noofcopy)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE book SET title=@title, noofcopy=@noofcopy WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@noofcopy", noofcopy);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

       



        public List<Book> GetBookList1(string name)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from book WHERE title=@name and status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", "active");
            List<Book> bookList = GetData(cmd);

            return bookList;


        }
    }
}
