namespace SW_project
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradebutt = new System.Windows.Forms.Button();
            this.coursebutt = new System.Windows.Forms.Button();
            this.taskbutt = new System.Windows.Forms.Button();
            this.notebutt = new System.Windows.Forms.Button();
            this.add_courses_butt = new System.Windows.Forms.Button();
            this.add_task_butt = new System.Windows.Forms.Button();
            this.take_note_butt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.gradebutt);
            this.panel1.Controls.Add(this.coursebutt);
            this.panel1.Controls.Add(this.taskbutt);
            this.panel1.Controls.Add(this.notebutt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // gradebutt
            // 
            this.gradebutt.BackColor = System.Drawing.Color.RoyalBlue;
            this.gradebutt.FlatAppearance.BorderSize = 0;
            this.gradebutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradebutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gradebutt.Location = new System.Drawing.Point(38, 340);
            this.gradebutt.Name = "gradebutt";
            this.gradebutt.Size = new System.Drawing.Size(123, 50);
            this.gradebutt.TabIndex = 1;
            this.gradebutt.Text = "Grade";
            this.gradebutt.UseVisualStyleBackColor = false;
            this.gradebutt.Click += new System.EventHandler(this.homebutt_Click);
            // 
            // coursebutt
            // 
            this.coursebutt.BackColor = System.Drawing.Color.RoyalBlue;
            this.coursebutt.FlatAppearance.BorderSize = 0;
            this.coursebutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursebutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.coursebutt.Location = new System.Drawing.Point(38, 108);
            this.coursebutt.Name = "coursebutt";
            this.coursebutt.Size = new System.Drawing.Size(123, 50);
            this.coursebutt.TabIndex = 2;
            this.coursebutt.Text = "My Courses";
            this.coursebutt.UseVisualStyleBackColor = false;
            this.coursebutt.Click += new System.EventHandler(this.coursebutt_Click);
            // 
            // taskbutt
            // 
            this.taskbutt.BackColor = System.Drawing.Color.RoyalBlue;
            this.taskbutt.FlatAppearance.BorderSize = 0;
            this.taskbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskbutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.taskbutt.Location = new System.Drawing.Point(38, 222);
            this.taskbutt.Name = "taskbutt";
            this.taskbutt.Size = new System.Drawing.Size(123, 50);
            this.taskbutt.TabIndex = 3;
            this.taskbutt.Text = "tasks";
            this.taskbutt.UseVisualStyleBackColor = false;
            this.taskbutt.Click += new System.EventHandler(this.button3_Click);
            // 
            // notebutt
            // 
            this.notebutt.BackColor = System.Drawing.Color.RoyalBlue;
            this.notebutt.FlatAppearance.BorderSize = 0;
            this.notebutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notebutt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notebutt.Location = new System.Drawing.Point(38, 12);
            this.notebutt.Name = "notebutt";
            this.notebutt.Size = new System.Drawing.Size(123, 50);
            this.notebutt.TabIndex = 4;
            this.notebutt.Text = "notes";
            this.notebutt.UseVisualStyleBackColor = false;
            this.notebutt.Click += new System.EventHandler(this.button4_Click);
            // 
            // add_courses_butt
            // 
            this.add_courses_butt.BackColor = System.Drawing.SystemColors.Highlight;
            this.add_courses_butt.Location = new System.Drawing.Point(668, 340);
            this.add_courses_butt.Name = "add_courses_butt";
            this.add_courses_butt.Size = new System.Drawing.Size(120, 55);
            this.add_courses_butt.TabIndex = 1;
            this.add_courses_butt.Text = "add course";
            this.add_courses_butt.UseVisualStyleBackColor = false;
            this.add_courses_butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_task_butt
            // 
            this.add_task_butt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.add_task_butt.Location = new System.Drawing.Point(243, 340);
            this.add_task_butt.Name = "add_task_butt";
            this.add_task_butt.Size = new System.Drawing.Size(120, 55);
            this.add_task_butt.TabIndex = 2;
            this.add_task_butt.Text = "add task";
            this.add_task_butt.UseVisualStyleBackColor = false;
            this.add_task_butt.Click += new System.EventHandler(this.add_task_butt_Click);
            // 
            // take_note_butt
            // 
            this.take_note_butt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.take_note_butt.Location = new System.Drawing.Point(464, 340);
            this.take_note_butt.Name = "take_note_butt";
            this.take_note_butt.Size = new System.Drawing.Size(120, 55);
            this.take_note_butt.TabIndex = 4;
            this.take_note_butt.Text = "take note";
            this.take_note_butt.UseVisualStyleBackColor = false;
            this.take_note_butt.Click += new System.EventHandler(this.take_note_butt_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.take_note_butt);
            this.Controls.Add(this.add_task_butt);
            this.Controls.Add(this.add_courses_butt);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button gradebutt;
        private System.Windows.Forms.Button coursebutt;
        private System.Windows.Forms.Button taskbutt;
        private System.Windows.Forms.Button notebutt;
        private System.Windows.Forms.Button add_courses_butt;
        private System.Windows.Forms.Button add_task_butt;
        private System.Windows.Forms.Button take_note_butt;
    }
}