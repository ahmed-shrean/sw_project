namespace SW_project
{
    partial class grades
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
            this.gradesReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradesReturn
            // 
            this.gradesReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradesReturn.Location = new System.Drawing.Point(29, 12);
            this.gradesReturn.Name = "gradesReturn";
            this.gradesReturn.Size = new System.Drawing.Size(90, 40);
            this.gradesReturn.TabIndex = 18;
            this.gradesReturn.Text = "Home";
            this.gradesReturn.UseVisualStyleBackColor = false;
            this.gradesReturn.Click += new System.EventHandler(this.gradesReturn_Click);
            // 
            // grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradesReturn);
            this.Name = "grades";
            this.Text = "grades";
            this.Load += new System.EventHandler(this.grades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gradesReturn;
    }
}