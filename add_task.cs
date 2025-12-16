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
            if (title.Text == "")
            {
                MessageBox.Show("add the title");
                return;
            }
            if (description.Text == "")
            {
                MessageBox.Show("add the description");
                return;
            }
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("wrong date");
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";
            string addTaskQuery = "INSERT INTO Tasks (Title,Description,Deadline)VALUES=(@name,@desc,@date)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(addTaskQuery, con);

                    // 3. ملي الفراغات
                    cmd.Parameters.AddWithValue("@name", title.Text);

                    // انتبه: بناخد التاريخ من الـ Value مش Text
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                    cmd.Parameters.AddWithValue("@desc", description.Text);

                    // 4. التنفيذ
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("task added ");

                    // نقفل الفورم الصغيرة دي بعد الحفظ
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حصل خطأ: " + ex.Message);
                }
            }
        }

        private void addTaskReturn_Click(object sender, EventArgs e)
        {
        
            home nextForm = new home();


            nextForm.Show();


            this.Hide();
       
        }
    }
}
