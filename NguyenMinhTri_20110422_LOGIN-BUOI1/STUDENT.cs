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
    class STUDENT
    {
        MY_DB mydb = new MY_DB();

        //function to insert a new student
        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture )
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic) ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }

        }
    }
}
