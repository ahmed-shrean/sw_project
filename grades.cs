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
    public partial class grades : Form
    {
        public grades()
        {
            InitializeComponent();
        }

        private void grades_Load(object sender, EventArgs e)
        {

        }

        private void gradesReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Hide();
        }
    }
}
