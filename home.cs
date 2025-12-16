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
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void homebutt_Click(object sender, EventArgs e)
        {
            grades nextForm = new grades();


            nextForm.Show();


            this.Hide();

        }

        private void coursebutt_Click(object sender, EventArgs e)
        {
            courses nextForm = new courses();


            nextForm.Show();


            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            task nextForm = new task();


            nextForm.Show();


            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            note nextForm = new note();


            nextForm.Show();


            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_courses nextForm = new add_courses();


            nextForm.Show();


            this.Hide();
        }

        private void add_task_butt_Click(object sender, EventArgs e)
        {
            add_task nextForm = new add_task();


            nextForm.Show();


            this.Hide();
        }

        private void take_note_butt_Click(object sender, EventArgs e)
        {
            take_note nextForm = new take_note();


            nextForm.Show();


            this.Hide();
        }
    }
}
