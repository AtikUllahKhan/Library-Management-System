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
    public class Borrows
    {
        public void InsertBorrow(Borrow s)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO borrow VALUES(@id,@studentid,@bookid,@issuedate,@returndate,@borrowstatus,@status)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", s.Id);
            cmd.Parameters.AddWithValue("@studentid", s.Studentid);
            cmd.Parameters.AddWithValue("@bookid", s.Bookid);
            cmd.Parameters.AddWithValue("@issuedate", s.Issuedate);
            cmd.Parameters.AddWithValue("@returndate", s.Returedate);
            cmd.Parameters.AddWithValue("@borrowstatus", s.Borrowstatus);
            cmd.Parameters.AddWithValue("@status", s.Status);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Borrow> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Borrow> list = new List<Borrow>();
            using (reader)
            {

                while (reader.Read())
                {
                    Borrow obj = new Borrow();
                    obj.Id = reader.GetString(0);
                    obj.Studentid = reader.GetString(1);
                    obj.Bookid = reader.GetString(2);
                    obj.Issuedate = reader.GetDateTime(3);
                    obj.Returedate = reader.GetDateTime(4);
                    obj.Borrowstatus = reader.GetString(5);
                    obj.Status = reader.GetString(6);
                    
                    list.Add(obj);
                }
                reader.Close();


            }
            cmd.Connection.Close();
            return list;



        }

        public Borrow GetData1(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Borrow obj = new Borrow();
            using (reader)
            {
                while (reader.Read())
                {

                    obj.Id = reader.GetString(0);
                    obj.Studentid = reader.GetString(1);
                    obj.Bookid = reader.GetString(2);
                    obj.Issuedate = reader.GetDateTime(3);
                    obj.Returedate = reader.GetDateTime(4);
                    obj.Borrowstatus = reader.GetString(5);
                    obj.Status = reader.GetString(6);


                }
                reader.Close();
            }
            cmd.Connection.Close();
            return obj;
        }

        public List<Borrow> GetBorrowList()
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from borrow WHERE status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@status", "active");
            List<Borrow> borrowList = GetData(cmd);
            return borrowList;


        }

        public Borrow GetBorrow(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from borrow WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            Borrow lib = new Borrow();
            lib = GetData1(cmd);

            return lib;


        }


        public void DeleteBorrow(string Id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE borrow SET status=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@status", "inactive");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }

        public void ReturnBorrow(string Id,DateTime returndate)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("UPDATE borrow SET returndate=@returndate,borrowstatus=@status WHERE id=@id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@returndate", returndate);
            cmd.Parameters.AddWithValue("@status", "returned");
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



        }



        public List<Borrow> GetBorrowList1(string id)
        {
            SqlDbDataAccess da = new SqlDbDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from borrow WHERE studentid=@id and status=@status");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@status", "active");
            List<Borrow> borrowList = GetData(cmd);

            return borrowList;


        }
    }
}
