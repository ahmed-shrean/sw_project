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

            // 1. تعديل جملة الـ INSERT لتشمل الـ UserID
            string addTaskQuery = "INSERT INTO Courses (CourseName, CourseCode, CreditHours, UserID) VALUES (@name, @code, @hours, @uid)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // 2. البحث عن التكرار في جدول Courses وليس Tasks، ولنفس المستخدم فقط
                    string checkQuery = "SELECT COUNT(*) FROM Courses WHERE (CourseName = @name OR CourseCode = @code) AND UserID = @uid";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@name", couresName.Text);
                    checkCmd.Parameters.AddWithValue("@code", courseCode.Text);
                    checkCmd.Parameters.AddWithValue("@uid", UserSession.UserID); // استخدام الـ ID المحفوظ

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("عفواً، هذا الكورس مضاف لديك بالفعل! 🚫");
                        return;
                    }

                    // 3. تنفيذ إضافة الكورس
                    SqlCommand cmd = new SqlCommand(addTaskQuery, con);
                    cmd.Parameters.AddWithValue("@name", couresName.Text);
                    cmd.Parameters.AddWithValue("@code", courseCode.Text);
                    cmd.Parameters.AddWithValue("@hours", creditHours.Text);
                    cmd.Parameters.AddWithValue("@uid", UserSession.UserID); // ربط الكورس باليوزر الحالي

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم إضافة الكورس بنجاح ✅");

                    // اختيار اختياري: مسح الخانات بعد الإضافة
                    couresName.Clear();
                    courseCode.Clear();
                    creditHours.Clear();
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
