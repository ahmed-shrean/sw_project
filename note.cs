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
/*CREATE TABLE Notes (
NoteID INT PRIMARY KEY IDENTITY(1,1),
Content NVARCHAR(MAX) NOT NULL,
CreatedAt DATETIME DEFAULT GETDATE(),
CourseID INT NOT NULL, -- Foreign Key to link with Course
FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);*/
{
    public partial class note : Form
    {
        public note()
        {
            InitializeComponent();
        }

        private void note_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            // 1. تعديل الاستعلام لإضافة شرط المستخدم الحالي (UserID)
            string query = @"SELECT Notes.Content, Notes.CreatedAt, Courses.CourseName 
                 FROM Notes 
                 INNER JOIN Courses ON Notes.CourseID = Courses.CourseID 
                 WHERE Notes.UserID = @uid";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // استخدمنا SqlCommand هنا لدعم الباراميترات (الخصوصية)
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", UserSession.UserID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                try
                {
                    adapter.Fill(table);

                    // 2. إعدادات التصميم لـ DataGridView
                    dataGridView1.RowTemplate.Height = 120;
                    dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    // منع إضافة سطور فارغة يدوياً وتغيير حجم الأعمدة تلقائياً
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // 3. تحميل البيانات
                    dataGridView1.DataSource = table;

                    // 4. تحسين شكل رؤوس الأعمدة (اختياري)
                    dataGridView1.Columns["Content"].HeaderText = "الملاحظة";
                    dataGridView1.Columns["CreatedAt"].HeaderText = "تاريخ الإنشاء";
                    dataGridView1.Columns["CourseName"].HeaderText = "اسم الكورس";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء عرض البيانات: " + ex.Message);
                }
            }
        }

        private void addTaskReturn_Click(object sender, EventArgs e)
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
