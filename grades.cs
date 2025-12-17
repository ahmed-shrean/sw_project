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

            string query = "SELECT ExamName,Score,MaxScore,CourseName FROM Grades INNER JOIN Courses ON Grades.CourseID = Courses.CourseID;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
           
            DataTable table = new DataTable();

            adapter.Fill(table);
           
            dataGridView1.DataSource = table;
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
