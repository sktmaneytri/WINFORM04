using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }

        /*
        public void Command(string query) // sign up
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thực hiện cấu trúc câu truy vấn
                sqlConnection.Close();
            }
        }
        */
    }
}
