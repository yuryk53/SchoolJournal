namespace SchoolJournalGUI
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageTeachers = new System.Windows.Forms.Button();
            this.btnShiftStudents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManageTeacherGroups = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMyProfile);
            this.flowLayoutPanel1.Controls.Add(this.btnManageStudents);
            this.flowLayoutPanel1.Controls.Add(this.btnManageTeachers);
            this.flowLayoutPanel1.Controls.Add(this.btnShiftStudents);
            this.flowLayoutPanel1.Controls.Add(this.btnManageTeacherGroups);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 227);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(3, 48);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(381, 39);
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.Text = "Manage students";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnManageTeachers
            // 
            this.btnManageTeachers.Location = new System.Drawing.Point(3, 93);
            this.btnManageTeachers.Name = "btnManageTeachers";
            this.btnManageTeachers.Size = new System.Drawing.Size(381, 39);
            this.btnManageTeachers.TabIndex = 2;
            this.btnManageTeachers.Text = "Manage teachers";
            this.btnManageTeachers.UseVisualStyleBackColor = true;
            this.btnManageTeachers.Click += new System.EventHandler(this.btnManageTeachers_Click);
            // 
            // btnShiftStudents
            // 
            this.btnShiftStudents.Location = new System.Drawing.Point(3, 138);
            this.btnShiftStudents.Name = "btnShiftStudents";
            this.btnShiftStudents.Size = new System.Drawing.Size(381, 39);
            this.btnShiftStudents.TabIndex = 3;
            this.btnShiftStudents.Text = "Shift all students to the next form";
            this.btnShiftStudents.UseVisualStyleBackColor = true;
            this.btnShiftStudents.Click += new System.EventHandler(this.btnShiftStudents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(434, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 195);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnManageTeacherGroups
            // 
            this.btnManageTeacherGroups.Location = new System.Drawing.Point(3, 183);
            this.btnManageTeacherGroups.Name = "btnManageTeacherGroups";
            this.btnManageTeacherGroups.Size = new System.Drawing.Size(381, 39);
            this.btnManageTeacherGroups.TabIndex = 4;
            this.btnManageTeacherGroups.Text = "Manage teacher study groups";
            this.btnManageTeacherGroups.UseVisualStyleBackColor = true;
            this.btnManageTeacherGroups.Click += new System.EventHandler(this.btnManageTeacherGroups_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 260);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminMenu";
            this.Text = "Admin Menu - School Journal";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageTeachers;
        private System.Windows.Forms.Button btnShiftStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManageTeacherGroups;
    }
}