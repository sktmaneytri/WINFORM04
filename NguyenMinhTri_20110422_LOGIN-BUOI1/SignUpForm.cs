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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }


        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkAccount (string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        MY_DB mydb = new MY_DB();
        public int CreateAutoID()
        {
            int id = 0;
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM login", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            id = table.Rows.Count;
            return id = id + 1;
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        { 
            ACCOUNT account = new ACCOUNT();
            string userName = userNameText.Text;
            string password = passwordText.Text;
            string verifypassword = verifiPassText.Text;
            if (!checkAccount(userName))
            {
                MessageBox.Show("Invalid username - include at least 10 characters!", "Sign Up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

             else if (!checkAccount(password))
            {
                MessageBox.Show("Invalid password - include at least 10 characters!", "Sign Up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             else if(verifypassword != password)
            {
                MessageBox.Show("Confirm password is incorrect!", "Sign Up error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                int Id = CreateAutoID();
                if(account.insertAccount(Id, userName, password))
                {
                    MessageBox.Show("Your new account is ready!", "Create account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
