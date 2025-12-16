using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_project
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @user AND PasswordHash = @pass";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@user", user_name.Text);

                cmd.Parameters.AddWithValue("@pass", password.Text);

                try
                {
                    con.Open();

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        home nextForm = new home();


                        nextForm.Show();


                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم أو كلمة المرور غلط");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حصل خطأ في الاتصال: " + ex.Message);
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regForm nextForm = new regForm();


            nextForm.Show();


            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lab_Click(object sender, EventArgs e)
        {

        }
    }
}
