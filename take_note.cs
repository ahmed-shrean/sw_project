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
    public partial class take_note : Form
    {
        public take_note()
        {
            InitializeComponent();
        }

        private void take_notebutt_Click(object sender, EventArgs e)
        {

        }

        private void take_note_Load(object sender, EventArgs e)
        {

        }

        private void takeNoteReturn_Click(object sender, EventArgs e)
        {
            home nextForm = new home();


            nextForm.Show();


            this.Hide();
        }
    }
}
