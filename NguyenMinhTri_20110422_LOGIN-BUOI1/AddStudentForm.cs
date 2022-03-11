using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(studentID_text.Text);
            string fname = firstName_text.Text;
            string lname = lastName_text.Text;
            DateTime bdate = birthDate_box.Value;
            string phone = phone_text.Text;
            string adrs = address_text.Text;
            string gender = "Male";
            if(gender_female_check.Checked)
            {
                gender = "Female";
            }
            MemoryStream PIC = new MemoryStream();
            int born_year = birthDate_box.Value.Year;
            int this_year = DateTime.Now.Year;

            if(((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must be between 1- and 100 - Try again!", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(verif())
            {
                picture_box.Image.Save(PIC, picture_box.Image.RawFormat);
                if(student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, PIC))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if((firstName_text.Text.Trim() == "")
                || (lastName_text.Text.Trim() == "")
                || (address_text.Text.Trim() == "")
                || (phone_text.Text.Trim() == "")
                || (picture_box.Image == null))
            {
                return false;
            } else
            {
                return true;
            }
                
        }

        private void uploadImage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif) |*.jpg;*.png;*gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                picture_box.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
