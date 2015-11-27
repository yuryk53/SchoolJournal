namespace SchoolJournalGUI
{
    partial class JournalViewWindow
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
            this.components = new System.ComponentModel.Container();
            this.gridJournal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripRowsFetched = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboStudyYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.attendanceJournalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridJournal)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceJournalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridJournal
            // 
            this.gridJournal.AllowUserToAddRows = false;
            this.gridJournal.AllowUserToDeleteRows = false;
            this.gridJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJournal.Location = new System.Drawing.Point(13, 42);
            this.gridJournal.Name = "gridJournal";
            this.gridJournal.Size = new System.Drawing.Size(876, 462);
            this.gridJournal.TabIndex = 0;
            this.gridJournal.DataSourceChanged += new System.EventHandler(this.gridJournal_DataSourceChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(220, 13);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(63, 13);
            this.lblTeacher.TabIndex = 4;
            this.lblTeacher.Text = "[lblTeacher]";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRowsFetched});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(901, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripRowsFetched
            // 
            this.toolStripRowsFetched.Name = "toolStripRowsFetched";
            this.toolStripRowsFetched.Size = new System.Drawing.Size(130, 17);
            this.toolStripRowsFetched.Text = "[toolStripRowsFetched]";
            // 
            // comboStudyYear
            // 
            this.comboStudyYear.FormattingEnabled = true;
            this.comboStudyYear.Location = new System.Drawing.Point(418, 9);
            this.comboStudyYear.Name = "comboStudyYear";
            this.comboStudyYear.Size = new System.Drawing.Size(121, 21);
            this.comboStudyYear.TabIndex = 7;
            this.comboStudyYear.SelectedIndexChanged += new System.EventHandler(this.comboStudyYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Study year:";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(58, 10);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(68, 21);
            this.comboBoxGrade.TabIndex = 9;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subject:";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(658, 9);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 10;
            // 
            // attendanceJournalBindingSource
            // 
            this.attendanceJournalBindingSource.DataSource = typeof(SJournalEFDAL.attendanceJournal);
            // 
            // JournalViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboStudyYear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridJournal);
            this.Name = "JournalViewWindow";
            this.Text = "JournalViewWindow";
            this.Load += new System.EventHandler(this.JournalViewWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridJournal)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceJournalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridJournal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.BindingSource attendanceJournalBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRowsFetched;
        private System.Windows.Forms.ComboBox comboStudyYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSubject;
    }
}