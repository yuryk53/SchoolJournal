namespace SchoolJournalGUI
{
    partial class StudentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnMyHomeTasks = new System.Windows.Forms.Button();
            this.btnChildProgress = new System.Windows.Forms.Button();
            this.btnChildOverallProgress = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMyProfile);
            this.flowLayoutPanel1.Controls.Add(this.btnMyHomeTasks);
            this.flowLayoutPanel1.Controls.Add(this.btnChildProgress);
            this.flowLayoutPanel1.Controls.Add(this.btnChildOverallProgress);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 181);
            this.flowLayoutPanel1.TabIndex = 5;
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
            // btnMyHomeTasks
            // 
            this.btnMyHomeTasks.Location = new System.Drawing.Point(3, 48);
            this.btnMyHomeTasks.Name = "btnMyHomeTasks";
            this.btnMyHomeTasks.Size = new System.Drawing.Size(381, 39);
            this.btnMyHomeTasks.TabIndex = 1;
            this.btnMyHomeTasks.Text = "My home tasks";
            this.btnMyHomeTasks.UseVisualStyleBackColor = true;
            this.btnMyHomeTasks.Click += new System.EventHandler(this.btnMyHomeTasks_Click);
            // 
            // btnChildProgress
            // 
            this.btnChildProgress.Location = new System.Drawing.Point(3, 93);
            this.btnChildProgress.Name = "btnChildProgress";
            this.btnChildProgress.Size = new System.Drawing.Size(381, 39);
            this.btnChildProgress.TabIndex = 2;
            this.btnChildProgress.Text = "My progress on subject";
            this.btnChildProgress.UseVisualStyleBackColor = true;
            this.btnChildProgress.Click += new System.EventHandler(this.btnChildProgress_Click);
            // 
            // btnChildOverallProgress
            // 
            this.btnChildOverallProgress.Location = new System.Drawing.Point(3, 138);
            this.btnChildOverallProgress.Name = "btnChildOverallProgress";
            this.btnChildOverallProgress.Size = new System.Drawing.Size(381, 39);
            this.btnChildOverallProgress.TabIndex = 3;
            this.btnChildOverallProgress.Text = "The overall progress";
            this.btnChildOverallProgress.UseVisualStyleBackColor = true;
            this.btnChildOverallProgress.Click += new System.EventHandler(this.btnChildOverallProgress_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StudentMenu";
            this.Text = "Student Menu - School Journal";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnMyHomeTasks;
        private System.Windows.Forms.Button btnChildProgress;
        private System.Windows.Forms.Button btnChildOverallProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}