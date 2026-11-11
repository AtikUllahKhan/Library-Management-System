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
    public class Libririans
    {
        public void InsertLibrarian(Librarian librarian)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO librarian VALUES(@id,@name,@email,@phoneno,@gender,@address,@salary,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", librarian.Id);
            cmd.Parameters.AddWithValue("@name", librarian.Name);
            cmd.Parameters.AddWithValue("@email", librarian.Email);
            cmd.Parameters.AddWithValue("@phoneno", librarian.Phoneno);
            cmd.Parameters.AddWithValue("@gender", librarian.Gender);
            cmd.Parameters.AddWithValue("@address", librarian.Address);
            cmd.Parameters.AddWithValue("@salary", librarian.Salary);
            cmd.Parameters.AddWithValue("@status", librarian.Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Librarian> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Librarian> list = new List<Librarian>();
            using (reader)
            {

                while (reader.Read())
                {
                    Librarian obj = new Librarian();
                    obj.Id = reader.GetString(0);
                    obj.Name = reader.GetString(1);
                    obj.Email = reader.GetString(2);
                    obj.Phoneno = reader.GetString(3);
                    obj.Gender = reader.GetString(4);
                    obj.Address = reader.GetString(5);
                    obj.Salary = reader.GetString(6);
                    obj.Status = reader.GetString(7);
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Librarian GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Librarian obj = new Librarian();
            using (reader)
            {
                while (reader.Read())
                {
                    
                    obj.Id = reader.GetString(0);
                    obj.Name = reader.GetString(1);
                    obj.Email = reader.GetString(2);
                    obj.Phoneno = reader.GetString(3);
                    obj.Gender = reader.GetString(4);
                    obj.Address = reader.GetString(5);
                    obj.Salary = reader.GetString(6);
                    obj.Status = reader.GetString(7);
                    

                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Librarian> GetLibrarianList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from librarian WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Librarian> librarianList = GetData(cmd);
            return librarianList;


        }

        public Librarian GetLibrarian(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from librarian WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Librarian lib = new Librarian();
            lib = GetData1(cmd);

            return lib;


        }


        public void DeleteLibrarian(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE librarian SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void UpdateLibrarian(String Id, string name, string salary)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE librarian SET name=@name, salary=@salary WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public void UpdateLibrarianSelf(String Id, string email, string Phoneno, string address)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE librarian SET email=@email,phoneno=@Phoneno,address=@address WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@Phoneno", Phoneno);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }
    }
}
