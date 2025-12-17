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

            // The query is perfect
            string query = "SELECT Content, CreatedAt, CourseName FROM Notes INNER JOIN Courses ON Notes.CourseID = Courses.CourseID;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            DataTable table = new DataTable();
            adapter.Fill(table);

            // 1. Set the height for the rows
            dataGridView1.RowTemplate.Height = 120;

            // 2. IMPORTANT: Enable text wrapping so the text uses the 120px height
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // 3. Load the data
            dataGridView1.DataSource = table;

            // 4. Optional: Fill the width of the screen
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
