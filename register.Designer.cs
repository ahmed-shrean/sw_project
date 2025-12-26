namespace SW_project
{
    partial class regForm
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
            this.regUserName = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.email_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // regUserName
            // 
            this.regUserName.Location = new System.Drawing.Point(246, 129);
            this.regUserName.Name = "regUserName";
            this.regUserName.Size = new System.Drawing.Size(100, 20);
            this.regUserName.TabIndex = 3;
            // 
            // regEmail
            // 
            this.regEmail.Location = new System.Drawing.Point(246, 168);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(100, 20);
            this.regEmail.TabIndex = 4;
            this.regEmail.TextChanged += new System.EventHandler(this.regEmail_TextChanged);
            // 
            // regPass
            // 
            this.regPass.Location = new System.Drawing.Point(246, 210);
            this.regPass.Name = "regPass";
            this.regPass.PasswordChar = '*';
            this.regPass.Size = new System.Drawing.Size(100, 20);
            this.regPass.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // email_error
            // 
            this.email_error.AutoSize = true;
            this.email_error.BackColor = System.Drawing.SystemColors.ControlLight;
            this.email_error.ForeColor = System.Drawing.Color.Red;
            this.email_error.Location = new System.Drawing.Point(253, 191);
            this.email_error.Name = "email_error";
            this.email_error.Size = new System.Drawing.Size(89, 13);
            this.email_error.TabIndex = 7;
            this.email_error.Text = "enter valied email";
            this.email_error.Visible = false;
            this.email_error.Click += new System.EventHandler(this.email_error_Click);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SW_project.Properties.Resources.log;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.email_error);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regPass);
            this.Controls.Add(this.regEmail);
            this.Controls.Add(this.regUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regForm";
            this.Text = "register";
            this.Load += new System.EventHandler(this.regForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regUserName;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.TextBox regPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label email_error;
    }
}