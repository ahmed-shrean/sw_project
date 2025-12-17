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

/*
 * 
 * CourseName NVARCHAR(100) NOT NULL,
    CourseCode NVARCHAR(20),
    CreditHours INT,

 */
namespace SW_project
{
    public partial class add_courses : Form
    {
        public add_courses()
        {
            InitializeComponent();
        }

        private void add_courses_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_courseButt_Click(object sender, EventArgs e)
        {
            

            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";
            string addTaskQuery = "INSERT INTO Tasks (CourseName,CourseCode,CreditHours)VALUES(@name,@code,@hours)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Tasks WHERE CourseName = @name OR CourseCode = @code";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@name", couresName.Text);
                    checkCmd.Parameters.AddWithValue("@code", courseCode.Text);

                    int count = (int)checkCmd.ExecuteScalar(); // بترجع رقم (عدد المتشابهات)

                    if (count > 0)
                    {
                        MessageBox.Show("عفواً، اسم الكورس أو الكود موجود بالفعل! 🚫");
                        return; // وقف الكود وماتكملش إضافة
                    }
                    SqlCommand cmd = new SqlCommand(addTaskQuery, con);

                    // 3. ملي الفراغات
                    cmd.Parameters.AddWithValue("@name", couresName.Text);

                    // انتبه: بناخد التاريخ من الـ Value مش Text
                    cmd.Parameters.AddWithValue("@code", courseCode.Text);

                    cmd.Parameters.AddWithValue("@hours", creditHours.Text);

                    // 4. التنفيذ
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("course added ");

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حصل خطأ: " + ex.Message);
                }
            }
        }

        private void addCourseReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Close();
        }

        private void creditHours_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
