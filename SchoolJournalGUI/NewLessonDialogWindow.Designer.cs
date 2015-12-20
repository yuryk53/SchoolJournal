namespace SchoolJournalGUI
{
    partial class NewLessonDialogWindow
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTeacherID = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.txtLessonTheme = new System.Windows.Forms.TextBox();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.txtHomeTask = new System.Windows.Forms.TextBox();
            this.btnCreateLesson = new System.Windows.Forms.Button();
            this.comboBoxNHours = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTeacherID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(465, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTeacherID
            // 
            this.toolStripTeacherID.Name = "toolStripTeacherID";
            this.toolStripTeacherID.Size = new System.Drawing.Size(113, 17);
            this.toolStripTeacherID.Text = "[toolStripTeacherID]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Subject title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lesson theme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Number of hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Grade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Home task:";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(140, 59);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(297, 21);
            this.comboBoxSubject.TabIndex = 25;
            // 
            // txtLessonTheme
            // 
            this.txtLessonTheme.Location = new System.Drawing.Point(140, 82);
            this.txtLessonTheme.Name = "txtLessonTheme";
            this.txtLessonTheme.Size = new System.Drawing.Size(297, 20);
            this.txtLessonTheme.TabIndex = 26;
            // 
            // comboGrade
            // 
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Location = new System.Drawing.Point(140, 128);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(297, 21);
            this.comboGrade.TabIndex = 28;
            // 
            // txtHomeTask
            // 
            this.txtHomeTask.Location = new System.Drawing.Point(140, 153);
            this.txtHomeTask.Name = "txtHomeTask";
            this.txtHomeTask.Size = new System.Drawing.Size(297, 20);
            this.txtHomeTask.TabIndex = 29;
            // 
            // btnCreateLesson
            // 
            this.btnCreateLesson.Location = new System.Drawing.Point(288, 192);
            this.btnCreateLesson.Name = "btnCreateLesson";
            this.btnCreateLesson.Size = new System.Drawing.Size(149, 28);
            this.btnCreateLesson.TabIndex = 30;
            this.btnCreateLesson.Text = "Create new lesson";
            this.btnCreateLesson.UseVisualStyleBackColor = true;
            this.btnCreateLesson.Click += new System.EventHandler(this.btnCreateLesson_Click);
            // 
            // comboBoxNHours
            // 
            this.comboBoxNHours.FormattingEnabled = true;
            this.comboBoxNHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxNHours.Location = new System.Drawing.Point(140, 105);
            this.comboBoxNHours.Name = "comboBoxNHours";
            this.comboBoxNHours.Size = new System.Drawing.Size(297, 21);
            this.comboBoxNHours.TabIndex = 31;
            // 
            // NewLessonDialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 262);
            this.Controls.Add(this.comboBoxNHours);
            this.Controls.Add(this.btnCreateLesson);
            this.Controls.Add(this.txtHomeTask);
            this.Controls.Add(this.comboGrade);
            this.Controls.Add(this.txtLessonTheme);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "NewLessonDialogWindow";
            this.Text = "Define parameters of new lesson";
            this.Load += new System.EventHandler(this.NewLessonDialogWindow_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTeacherID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.TextBox txtLessonTheme;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.TextBox txtHomeTask;
        private System.Windows.Forms.Button btnCreateLesson;
        private System.Windows.Forms.ComboBox comboBoxNHours;
    }
}