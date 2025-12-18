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
/*CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    CourseCode NVARCHAR(20),
    CreditHours INT,
    UserID INT NOT NULL, -- Foreign Key to link with User
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);*/
namespace SW_project
{
    public partial class courses : Form
    {
        public courses()
        {
            InitializeComponent();
        }

        private void courses_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            // 1. إضافة شرط WHERE لضمان الخصوصية
            string query = "SELECT CourseName, CourseCode, CreditHours FROM Courses WHERE UserID = @uid";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // استخدمنا SqlCommand لدعم الباراميترات
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", UserSession.UserID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                try
                {
                    adapter.Fill(table);

                    // 2. تحسين شكل الـ DataGridView
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false; // لمنع ظهور السطر الفارغ الأخير
                    dataGridView1.ReadOnly = true; // لمنع اليوزر من تعديل البيانات مباشرة في الجدول

                    // 3. ربط البيانات
                    dataGridView1.DataSource = table;

                    // 4. تغيير أسماء الأعمدة لتظهر بشكل احترافي
                    dataGridView1.Columns["CourseName"].HeaderText = "اسم الكورس";
                    dataGridView1.Columns["CourseCode"].HeaderText = "كود المادة";
                    dataGridView1.Columns["CreditHours"].HeaderText = "الساعات المعتمدة";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
                }
            }
        }

        private void courseReturn_Click(object sender, EventArgs e)
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
