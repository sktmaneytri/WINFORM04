using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    class ACCOUNT
    {
        MY_DB mydb = new MY_DB();
        //function insert a new account 
        public bool insertAccount(int Id, string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login(Id, username, password)" + "VALUES (@id, @usn, @psw)", mydb.getConnection );
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@usn", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@psw", SqlDbType.VarChar).Value = password;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
