namespace SW_project
{
    partial class addgrade
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
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.examname = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.TextBox();
            this.max_score = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.TextBox();
            this.gradesReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "exam name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Score";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "course";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(259, 312);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // examname
            // 
            this.examname.Location = new System.Drawing.Point(259, 108);
            this.examname.Name = "examname";
            this.examname.Size = new System.Drawing.Size(100, 20);
            this.examname.TabIndex = 5;
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(259, 156);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(100, 20);
            this.score.TabIndex = 6;
            // 
            // max_score
            // 
            this.max_score.Location = new System.Drawing.Point(259, 194);
            this.max_score.Name = "max_score";
            this.max_score.Size = new System.Drawing.Size(100, 20);
            this.max_score.TabIndex = 7;
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(259, 230);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(100, 20);
            this.course.TabIndex = 8;
            // 
            // gradesReturn
            // 
            this.gradesReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradesReturn.Location = new System.Drawing.Point(12, 12);
            this.gradesReturn.Name = "gradesReturn";
            this.gradesReturn.Size = new System.Drawing.Size(90, 40);
            this.gradesReturn.TabIndex = 19;
            this.gradesReturn.Text = "Home";
            this.gradesReturn.UseVisualStyleBackColor = false;
            this.gradesReturn.Click += new System.EventHandler(this.gradesReturn_Click);
            // 
            // addgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradesReturn);
            this.Controls.Add(this.course);
            this.Controls.Add(this.max_score);
            this.Controls.Add(this.score);
            this.Controls.Add(this.examname);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addgrade";
            this.Text = "addgrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox examname;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.TextBox max_score;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Button gradesReturn;
    }
}