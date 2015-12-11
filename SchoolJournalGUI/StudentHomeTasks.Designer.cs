namespace SchoolJournalGUI
{
    partial class StudentHomeTasks
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
            this.dataGridViewHomeTask = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateInteval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHomeTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHomeTask
            // 
            this.dataGridViewHomeTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHomeTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHomeTask.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewHomeTask.Name = "dataGridViewHomeTask";
            this.dataGridViewHomeTask.ReadOnly = true;
            this.dataGridViewHomeTask.Size = new System.Drawing.Size(1013, 411);
            this.dataGridViewHomeTask.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1019, 475);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 1016;
            this.lineShape1.Y1 = 32;
            this.lineShape1.Y2 = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(72, 12);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 13);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "lblStudentID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(202, 11);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(46, 13);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "lblGrade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date interval:";
            // 
            // lblDateInteval
            // 
            this.lblDateInteval.AutoSize = true;
            this.lblDateInteval.Location = new System.Drawing.Point(394, 12);
            this.lblDateInteval.Name = "lblDateInteval";
            this.lblDateInteval.Size = new System.Drawing.Size(72, 13);
            this.lblDateInteval.TabIndex = 7;
            this.lblDateInteval.Text = "lblDateInteval";
            // 
            // StudentHomeTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 475);
            this.Controls.Add(this.lblDateInteval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHomeTask);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "StudentHomeTasks";
            this.Text = "My Home Tasks - School Journal";
            this.Load += new System.EventHandler(this.StudentHomeTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHomeTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHomeTask;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateInteval;
    }
}