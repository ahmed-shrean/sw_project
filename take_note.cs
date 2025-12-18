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
/*CREATE TABLE Notes (
    NoteID INT PRIMARY KEY IDENTITY(1,1),
    Content NVARCHAR(MAX) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CourseID INT NOT NULL, -- Foreign Key to link with Course
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);
GO*/
namespace SW_project
{
    public partial class take_note : Form
    {
        public take_note()
        {
            InitializeComponent();
        }

        private void take_notebutt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Content.Text) || string.IsNullOrWhiteSpace(note_course.Text))
            {
                MessageBox.Show("Please enter both the Note Content and the Course Name.");
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO Notes (Content, CourseID, UserID) 
                         SELECT @Content, CourseID, UserID 
                         FROM Courses 
                         WHERE CourseName = @CourseName AND UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Content", Content.Text);
                        cmd.Parameters.AddWithValue("@CourseName", note_course.Text);
                        cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Note saved successfully!");
                            Content.Clear();
                            note_course.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error: The Course Name you entered does not exist for your account.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        private void take_note_Load(object sender, EventArgs e)
        {

        }

        private void takeNoteReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Close();
        }
    }
}
