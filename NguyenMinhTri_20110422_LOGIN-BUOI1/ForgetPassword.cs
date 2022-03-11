using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MY_DB mydb = new MY_DB();
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            /*
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = N'" + userNameText.Text, db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            */
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = userNameText.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                if(NewPassText.Text == ConfirmPassText.Text)
                {
                    SqlCommand command1 = new SqlCommand("UPDATE login set password = N' " + NewPassText.Text + "' WHERE username = N'"
                    + userNameText.Text);
                    MessageBox.Show("Password change succesfully!", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Invalid Password!", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Invalid Username!", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
