namespace SW_project
{
    partial class take_note
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
            this.context = new System.Windows.Forms.TextBox();
            this.note_note = new System.Windows.Forms.TextBox();
            this.take_notebutt = new System.Windows.Forms.Button();
            this.takeNoteReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "context";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "course";
            // 
            // context
            // 
            this.context.Location = new System.Drawing.Point(272, 127);
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(100, 20);
            this.context.TabIndex = 2;
            // 
            // note_note
            // 
            this.note_note.Location = new System.Drawing.Point(272, 197);
            this.note_note.Name = "note_note";
            this.note_note.Size = new System.Drawing.Size(100, 20);
            this.note_note.TabIndex = 3;
            // 
            // take_notebutt
            // 
            this.take_notebutt.Location = new System.Drawing.Point(272, 245);
            this.take_notebutt.Name = "take_notebutt";
            this.take_notebutt.Size = new System.Drawing.Size(75, 23);
            this.take_notebutt.TabIndex = 4;
            this.take_notebutt.Text = "save";
            this.take_notebutt.UseVisualStyleBackColor = true;
            this.take_notebutt.Click += new System.EventHandler(this.take_notebutt_Click);
            // 
            // takeNoteReturn
            // 
            this.takeNoteReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.takeNoteReturn.Location = new System.Drawing.Point(35, 28);
            this.takeNoteReturn.Name = "takeNoteReturn";
            this.takeNoteReturn.Size = new System.Drawing.Size(90, 40);
            this.takeNoteReturn.TabIndex = 18;
            this.takeNoteReturn.Text = "Home";
            this.takeNoteReturn.UseVisualStyleBackColor = false;
            this.takeNoteReturn.Click += new System.EventHandler(this.takeNoteReturn_Click);
            // 
            // take_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.takeNoteReturn);
            this.Controls.Add(this.take_notebutt);
            this.Controls.Add(this.note_note);
            this.Controls.Add(this.context);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "take_note";
            this.Text = "take_note";
            this.Load += new System.EventHandler(this.take_note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox context;
        private System.Windows.Forms.TextBox note_note;
        private System.Windows.Forms.Button take_notebutt;
        private System.Windows.Forms.Button takeNoteReturn;
    }
}