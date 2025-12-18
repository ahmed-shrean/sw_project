namespace SW_project
{
    partial class add_task
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
            this.add_taskButt = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laa = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addTaskReturn = new System.Windows.Forms.Button();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // add_taskButt
            // 
            this.add_taskButt.Location = new System.Drawing.Point(290, 318);
            this.add_taskButt.Name = "add_taskButt";
            this.add_taskButt.Size = new System.Drawing.Size(75, 23);
            this.add_taskButt.TabIndex = 13;
            this.add_taskButt.Text = "save";
            this.add_taskButt.UseVisualStyleBackColor = true;
            this.add_taskButt.Click += new System.EventHandler(this.add_taskButt_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(290, 165);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 20);
            this.description.TabIndex = 11;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(290, 110);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "deadline";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "titel";
            // 
            // laa
            // 
            this.laa.AutoSize = true;
            this.laa.Location = new System.Drawing.Point(204, 270);
            this.laa.Name = "laa";
            this.laa.Size = new System.Drawing.Size(39, 13);
            this.laa.TabIndex = 14;
            this.laa.Text = "course";
            this.laa.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // addTaskReturn
            // 
            this.addTaskReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addTaskReturn.Location = new System.Drawing.Point(27, 29);
            this.addTaskReturn.Name = "addTaskReturn";
            this.addTaskReturn.Size = new System.Drawing.Size(90, 40);
            this.addTaskReturn.TabIndex = 17;
            this.addTaskReturn.Text = "Home";
            this.addTaskReturn.UseVisualStyleBackColor = false;
            this.addTaskReturn.Click += new System.EventHandler(this.addTaskReturn_Click);
            // 
            // courseComboBox
            // 
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(290, 262);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(121, 21);
            this.courseComboBox.TabIndex = 18;
            // 
            // add_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.addTaskReturn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.laa);
            this.Controls.Add(this.add_taskButt);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_task";
            this.Text = "add_task";
            this.Load += new System.EventHandler(this.add_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_taskButt;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addTaskReturn;
        private System.Windows.Forms.ComboBox courseComboBox;
    }
}