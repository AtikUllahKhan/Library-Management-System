using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Management_System.Models
{
    public class SqlDbDataAccess
    {
        private const string V = @"Data Source=Atik-Khan;Initial Catalog=""Library"";User ID=sa;Password=atik";
        const string Connectionstring = V;


        public SqlCommand GetCommand(string query)
        {
            var connection = new SqlConnection(Connectionstring);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
    }
}
