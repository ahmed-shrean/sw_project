using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SW_project
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void homebutt_Click(object sender, EventArgs e)
        {
            grades nextForm = new grades();


            nextForm.Show();


            this.Hide();

        }

        private void coursebutt_Click(object sender, EventArgs e)
        {
            courses nextForm = new courses();


            nextForm.Show();


            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            task nextForm = new task();


            nextForm.Show();


            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            note nextForm = new note();


            nextForm.Show();


            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {


            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            // Query بيحسب المتوسط الموزون: (الدرجة * الساعات) / مجموع الساعات
            string query = @"SELECT 
                        CASE 
                            WHEN SUM(c.CreditHours) = 0 THEN 0 
                            ELSE SUM((g.Score / g.MaxScore) * 4.0 * c.CreditHours) / SUM(c.CreditHours) 
                        END as GPA
                     FROM Grades g
                     INNER JOIN Courses c ON g.CourseID = c.CourseID
                     WHERE g.UserID = @uid";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@uid", UserSession.UserID);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        double gpa = Convert.ToDouble(result);
                        // عرض النتيجة وتقريبها لأقرب رقمين عشريين
                        show_gpa.Text = "Your GPA: " + gpa.ToString("0.00");
                    }
                    else
                    {
                        show_gpa.Text = "Your GPA: 0.00";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating GPA: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_courses nextForm = new add_courses();


            nextForm.Show();


            this.Hide();
        }

        private void add_task_butt_Click(object sender, EventArgs e)
        {
            add_task nextForm = new add_task();


            nextForm.Show();


            this.Hide();
        }

        private void take_note_butt_Click(object sender, EventArgs e)
        {
            take_note nextForm = new take_note();


            nextForm.Show();


            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addgrade nextForm = new addgrade();


            nextForm.Show();


            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Formlogin nextForm = new Formlogin();


            nextForm.Show();


            this.Hide();
        }

        private void show_gpa_Click(object sender, EventArgs e)
        {

        }
    }
    }

