using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * 
 TaskID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Deadline DATETIME,
    IsCompleted BIT DEFAULT 0, -- 0 = Pending, 1 = Completed
    CourseID INT NOT NULL, -- Foreign Key to link with Course
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);*/
namespace SW_project
{
    public partial class add_task : Form
    {
        public add_task()
        {
            InitializeComponent();
        }

        private void add_task_Load(object sender, EventArgs e)
        {
        
            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";
            // بنختار الكورسات الخاصة باليوزر اللي عامل Login بس
            string query = "SELECT CourseID, CourseName FROM Courses WHERE UserID = @uid";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@uid", UserSession.UserID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // ربط الداتا تيبل بالـ ComboBox
                    courseComboBox.DataSource = dt;
                    courseComboBox.DisplayMember = "CourseName"; // النص اللي هيظهر
                    courseComboBox.ValueMember = "CourseID";    // القيمة اللي هناخدها في الكود

                    // اختياري: جعل الكومبوبوكس يبدأ بـ "اختر كورس" أو فاضي
                    courseComboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل الكورسات: " + ex.Message);
                }
            }
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_taskButt_Click(object sender, EventArgs e)
        {
            // 1. التحقق من البيانات المدخلة
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show("برجاء إضافة العنوان");
                return;
            }
            if (courseComboBox.SelectedValue == null)
            {
                MessageBox.Show("برجاء اختيار الكورس التابع له هذه المهمة");
                return;
            }
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("التاريخ غير منطقي! اختر تاريخ اليوم أو مستقبلي");
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            // 2. تصحيح جملة الـ SQL وإضافة الـ IDs المطلوبة
            string addTaskQuery = "INSERT INTO Tasks (Title, Description, Deadline, CourseID, UserID) " +
                                 "VALUES (@title, @desc, @date, @courseId, @userId)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(addTaskQuery, con);

                    // 3. ملء الباراميترات
                    cmd.Parameters.AddWithValue("@title", title.Text);
                    cmd.Parameters.AddWithValue("@desc", description.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                    // نأخذ الـ CourseID من الـ ComboBox
                    cmd.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue);

                    // نأخذ الـ UserID من الـ Session الذي أنشأناه عند تسجيل الدخول
                    cmd.Parameters.AddWithValue("@userId", UserSession.UserID);

                    // 4. التنفيذ
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم إضافة المهمة بنجاح ✅");

                    // مسح الخانات بعد الإضافة
                    title.Clear();
                    description.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حصل خطأ في قاعدة البيانات: " + ex.Message);
                }
            }
        }
        private void addTaskReturn_Click(object sender, EventArgs e)
        {
        
            home nextForm = new home();


            nextForm.Show();


            this.Close();
       
        }
    }
}
