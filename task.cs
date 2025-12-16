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

            string query = "SELECT Title,Description,Deadline,IsCompleted ,CourseID FROM Tasks";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void TaskReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
