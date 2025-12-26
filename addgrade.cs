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
namespace SW_project
/*
 CREATE TABLE Grades (
    GradeID INT PRIMARY KEY IDENTITY(1,1),
    ExamName NVARCHAR(50), -- e.g., Midterm, Final
    Score FLOAT NOT NULL,
    MaxScore FLOAT NOT NULL,
    CourseID INT NOT NULL, -- Foreign Key to link with Course
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
);
G
 */
{
    public partial class addgrade : Form
    {
        public addgrade()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(examname.Text) || string.IsNullOrWhiteSpace(course.Text) || string.IsNullOrWhiteSpace(max_score.Text) || string.IsNullOrWhiteSpace(score.Text))
            {
                MessageBox.Show("Please enter all the record.");
                return;
            }

            string connectionString = "Data Source=.;Initial Catalog=StudentOrganizerDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO Grades (ExamName, Score, MaxScore, CourseID, UserID) 
                         SELECT @ExamName, @Score, @MaxScore, CourseID, UserID 
                         FROM Courses 
                         WHERE CourseName = @CourseName AND UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ExamName", examname.Text);
                        cmd.Parameters.AddWithValue("@CourseName", course.Text);
                        cmd.Parameters.AddWithValue("@MaxScore", float.Parse(max_score.Text));
                        cmd.Parameters.AddWithValue("@Score", float.Parse(score.Text));
                        cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade saved successfully!");
                            examname.Clear();
                            course.Clear();
                            max_score.Clear();
                            score.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error: Course not found for this user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void gradesReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Close();

        }

        private void course_TextChanged(object sender, EventArgs e)
        {

        }

        private void max_score_TextChanged(object sender, EventArgs e)
        {

        }

        private void score_TextChanged(object sender, EventArgs e)
        {

        }

        private void examname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
