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
            if (string.IsNullOrWhiteSpace(examname.Text) || string.IsNullOrWhiteSpace(course.Text)|| string.IsNullOrWhiteSpace(max_score.Text)|| string.IsNullOrWhiteSpace(score.Text))
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

                    // 2. The Smart Query: Finds the CourseID based on the Name and Inserts the Note
                    string query = @"INSERT INTO Grades (ExamName, Score,MaxScore) 
                             SELECT @ExamName, @Score,@MaxScore, CourseID 
                             FROM Courses 
                             WHERE CourseName = @CourseName";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 3. Add Parameters (Prevents errors and hacking)
                        cmd.Parameters.AddWithValue("@ExamName", examname.Text);
                        cmd.Parameters.AddWithValue("@CourseName", course.Text);
                        cmd.Parameters.AddWithValue("@MaxScore", max_score.Text);
                        cmd.Parameters.AddWithValue("@Score", score.Text);

                        // 4. Execute
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // 5. Check if it worked
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Note saved successfully!");
                            examname.Clear();
                            course.Clear();
                            max_score.Clear();
                            score.Clear();
                        }
                        else
                        {
                            // If rowsAffected is 0, it means the Course Name didn't exist in the database
                            MessageBox.Show("Error: The Course Name you entered does not exist. Please check the spelling.");
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
    }
}
