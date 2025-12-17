using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_project
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+(\.[-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+)*))@([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(regEmail.Text, emailPattern))
            {
                email_error.Visible = true;
                MessageBox.Show("Please enter a valid email");
                return;
            }

            email_error.Visible = false;

            if (regUserName.Text == "" || regPass.Text == "")
            {
                MessageBox.Show("Please enter user name and password");
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @checkMail";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@checkMail", regEmail.Text);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("الإيميل ده متسجل قبل كده، جرب تعمل Login");
                        return;
                    }

                    string insertQuery = "INSERT INTO Users (Username, PasswordHash, Email) VALUES (@user, @pass, @mail)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@user", regUserName.Text);
                    insertCmd.Parameters.AddWithValue("@pass", regPass.Text); // لاحظ ملحوظة تحت عن الباسورد
                    insertCmd.Parameters.AddWithValue("@mail", regEmail.Text);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Account created successfully! 🎉");

                    regUserName.Text = "";
                    regPass.Text = "";
                    regEmail.Text = "";

                    Formlogin nextForm = new Formlogin();
                    nextForm.Show();
                    this.Close();

                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("خطأ في قاعدة البيانات: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حصل خطأ غير متوقع: " + ex.Message);
                }
            }
        }

        private void regForm_Load(object sender, EventArgs e)
        {

        }

        private void regEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_error_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+(\.[-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+)*))@([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}$";
            if (Regex.IsMatch(regEmail.Text,emailPattern))
            
           { email_error.Visible = false; }
            else { email_error.Visible = true; }
        }
    }
}

