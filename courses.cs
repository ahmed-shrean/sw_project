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

            string query = "SELECT CourseName,CourseCode,CreditHours FROM Courses";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
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
