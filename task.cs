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
/*CREATE TABLE Tasks (
TaskID INT PRIMARY KEY IDENTITY(1,1),
Title NVARCHAR(100) NOT NULL,
Description NVARCHAR(MAX),
Deadline DATETIME,
IsCompleted BIT DEFAULT 0, -- 0 = Pending, 1 = Completed
CourseID INT NOT NULL, -- Foreign Key to link with Course
FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);*/
{
    public partial class task : Form
    {
        public task()
        {
            InitializeComponent();
        }

        private void task_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            // 1. استخدام INNER JOIN لجلب اسم الكورس وفلترة البيانات حسب المستخدم
            string query = @"SELECT Tasks.Title, Tasks.Description, Tasks.Deadline, 
                 Tasks.IsCompleted, Courses.CourseName 
                 FROM Tasks 
                 INNER JOIN Courses ON Tasks.CourseID = Courses.CourseID 
                 WHERE Tasks.UserID = @uid";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", UserSession.UserID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                try
                {
                    adapter.Fill(table);

                    // 2. تنسيق الجدول
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.ReadOnly = true;

                    // 3. ربط البيانات
                    dataGridView1.DataSource = table;

                    // 4. تحسين مظهر أسماء الأعمدة
                    dataGridView1.Columns["Title"].HeaderText = "المهمة";
                    dataGridView1.Columns["Description"].HeaderText = "الوصف";
                    dataGridView1.Columns["Deadline"].HeaderText = "الموعد النهائي";
                    dataGridView1.Columns["IsCompleted"].HeaderText = "تم الإنجاز";
                    dataGridView1.Columns["CourseName"].HeaderText = "الكورس";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل المهام: " + ex.Message);
                }
            }
        }

        private void TaskReturn_Click(object sender, EventArgs e)
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
