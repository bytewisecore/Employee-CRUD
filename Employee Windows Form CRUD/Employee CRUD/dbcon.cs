using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_CRUD
{

    class dbcon
    {

        SqlConnection con;
        public dbcon(string query)
        {
            connection(query);
        }
        public void connection(string connectionstring)
        {
            con = new SqlConnection(connectionstring);
        }
        public bool UDI(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            bool check = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return check;
        }
        public DataTable search(string query)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
