namespace SW_project
{
    partial class add_courses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.couresName = new System.Windows.Forms.TextBox();
            this.courseCode = new System.Windows.Forms.TextBox();
            this.creditHours = new System.Windows.Forms.TextBox();
            this.add_courseButt = new System.Windows.Forms.Button();
            this.addCourseReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "course name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "course code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Hours";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // couresName
            // 
            this.couresName.Location = new System.Drawing.Point(174, 98);
            this.couresName.Name = "couresName";
            this.couresName.Size = new System.Drawing.Size(100, 20);
            this.couresName.TabIndex = 3;
            // 
            // courseCode
            // 
            this.courseCode.Location = new System.Drawing.Point(174, 153);
            this.courseCode.Name = "courseCode";
            this.courseCode.Size = new System.Drawing.Size(100, 20);
            this.courseCode.TabIndex = 4;
            // 
            // creditHours
            // 
            this.creditHours.Location = new System.Drawing.Point(174, 209);
            this.creditHours.Name = "creditHours";
            this.creditHours.Size = new System.Drawing.Size(100, 20);
            this.creditHours.TabIndex = 5;
            this.creditHours.TextChanged += new System.EventHandler(this.creditHours_TextChanged);
            // 
            // add_courseButt
            // 
            this.add_courseButt.Location = new System.Drawing.Point(174, 306);
            this.add_courseButt.Name = "add_courseButt";
            this.add_courseButt.Size = new System.Drawing.Size(75, 23);
            this.add_courseButt.TabIndex = 6;
            this.add_courseButt.Text = "save";
            this.add_courseButt.UseVisualStyleBackColor = true;
            this.add_courseButt.Click += new System.EventHandler(this.add_courseButt_Click);
            // 
            // addCourseReturn
            // 
            this.addCourseReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCourseReturn.Location = new System.Drawing.Point(27, 31);
            this.addCourseReturn.Name = "addCourseReturn";
            this.addCourseReturn.Size = new System.Drawing.Size(90, 40);
            this.addCourseReturn.TabIndex = 7;
            this.addCourseReturn.Text = "Home";
            this.addCourseReturn.UseVisualStyleBackColor = false;
            this.addCourseReturn.Click += new System.EventHandler(this.addCourseReturn_Click);
            // 
            // add_courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SW_project.Properties.Resources.add_ciurse;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.addCourseReturn);
            this.Controls.Add(this.add_courseButt);
            this.Controls.Add(this.creditHours);
            this.Controls.Add(this.courseCode);
            this.Controls.Add(this.couresName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_courses";
            this.Text = "add_courses";
            this.Load += new System.EventHandler(this.add_courses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox couresName;
        private System.Windows.Forms.TextBox courseCode;
        private System.Windows.Forms.TextBox creditHours;
        private System.Windows.Forms.Button add_courseButt;
        private System.Windows.Forms.Button addCourseReturn;
    }
}