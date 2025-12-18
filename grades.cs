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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/*CREATE TABLE Grades (
    GradeID INT PRIMARY KEY IDENTITY(1,1),
    ExamName NVARCHAR(50), -- e.g., Midterm, Final
    Score FLOAT NOT NULL,
    MaxScore FLOAT NOT NULL,
    CourseID INT NOT NULL, -- Foreign Key to link with Course
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);
GO*/
namespace SW_project
{
    public partial class grades : Form
    {
        public grades()
        {
            InitializeComponent();
        }

        private void grades_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            // 1. تعديل الاستعلام لإضافة شرط الخصوصية (UserID)
            string query = @"SELECT Grades.ExamName, Grades.Score, Grades.MaxScore, Courses.CourseName 
                 FROM Grades 
                 INNER JOIN Courses ON Grades.CourseID = Courses.CourseID 
                 WHERE Grades.UserID = @uid";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // استخدام SqlCommand لتمرير الباراميتر بشكل آمن
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", UserSession.UserID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                try
                {
                    adapter.Fill(table);

                    // 2. تحسين شكل الـ DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.ReadOnly = true;

                    // 3. ربط البيانات
                    dataGridView1.DataSource = table;

                    // 4. تغيير أسماء رؤوس الأعمدة لتظهر بالعربية
                    dataGridView1.Columns["ExamName"].HeaderText = "اسم الامتحان";
                    dataGridView1.Columns["Score"].HeaderText = "الدرجة";
                    dataGridView1.Columns["MaxScore"].HeaderText = "الدرجة النهائية";
                    dataGridView1.Columns["CourseName"].HeaderText = "اسم الكورس";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل الدرجات: " + ex.Message);
                }
            }
        }

        private void gradesReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
