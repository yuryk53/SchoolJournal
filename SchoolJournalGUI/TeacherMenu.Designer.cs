namespace SchoolJournalGUI
{
    partial class TeacherMenu
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnViewJournal = new System.Windows.Forms.Button();
            this.btnStartNewLesson = new System.Windows.Forms.Button();
            this.btnListOfStudents = new System.Windows.Forms.Button();
            this.btnMyStudyGroups = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(417, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMyProfile);
            this.flowLayoutPanel1.Controls.Add(this.btnViewJournal);
            this.flowLayoutPanel1.Controls.Add(this.btnStartNewLesson);
            this.flowLayoutPanel1.Controls.Add(this.btnListOfStudents);
            this.flowLayoutPanel1.Controls.Add(this.btnMyStudyGroups);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 234);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(3, 3);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(381, 39);
            this.btnMyProfile.TabIndex = 0;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnViewJournal
            // 
            this.btnViewJournal.Location = new System.Drawing.Point(3, 48);
            this.btnViewJournal.Name = "btnViewJournal";
            this.btnViewJournal.Size = new System.Drawing.Size(381, 39);
            this.btnViewJournal.TabIndex = 1;
            this.btnViewJournal.Text = "View Journal";
            this.btnViewJournal.UseVisualStyleBackColor = true;
            this.btnViewJournal.Click += new System.EventHandler(this.btnViewJournal_Click);
            // 
            // btnStartNewLesson
            // 
            this.btnStartNewLesson.Location = new System.Drawing.Point(3, 93);
            this.btnStartNewLesson.Name = "btnStartNewLesson";
            this.btnStartNewLesson.Size = new System.Drawing.Size(381, 39);
            this.btnStartNewLesson.TabIndex = 2;
            this.btnStartNewLesson.Text = "Start New Lesson";
            this.btnStartNewLesson.UseVisualStyleBackColor = true;
            this.btnStartNewLesson.Click += new System.EventHandler(this.btnStartNewLesson_Click);
            // 
            // btnListOfStudents
            // 
            this.btnListOfStudents.Location = new System.Drawing.Point(3, 138);
            this.btnListOfStudents.Name = "btnListOfStudents";
            this.btnListOfStudents.Size = new System.Drawing.Size(381, 39);
            this.btnListOfStudents.TabIndex = 3;
            this.btnListOfStudents.Text = "List of students";
            this.btnListOfStudents.UseVisualStyleBackColor = true;
            this.btnListOfStudents.Click += new System.EventHandler(this.btnListOfStudents_Click);
            // 
            // btnMyStudyGroups
            // 
            this.btnMyStudyGroups.Location = new System.Drawing.Point(3, 183);
            this.btnMyStudyGroups.Name = "btnMyStudyGroups";
            this.btnMyStudyGroups.Size = new System.Drawing.Size(381, 39);
            this.btnMyStudyGroups.TabIndex = 4;
            this.btnMyStudyGroups.Text = "My Study Groups";
            this.btnMyStudyGroups.UseVisualStyleBackColor = true;
            this.btnMyStudyGroups.Click += new System.EventHandler(this.btnMyStudyGroups_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 258);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "TeacherMenu";
            this.Text = "TeacherMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnViewJournal;
        private System.Windows.Forms.Button btnStartNewLesson;
        private System.Windows.Forms.Button btnListOfStudents;
        private System.Windows.Forms.Button btnMyStudyGroups;
    }
}