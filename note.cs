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

            string query = "SELECT Content,CreatedAt,CourseID FROM Notes";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void addTaskReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Hide();
        }
    }
}
