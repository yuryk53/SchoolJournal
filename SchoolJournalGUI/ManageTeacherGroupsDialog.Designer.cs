namespace SchoolJournalGUI
{
    partial class ManageTeacherGroupsDialog
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.getTeacherNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schooljournalDataSet = new SchoolJournalGUI.schooljournalDataSet();
            this.btnGo = new System.Windows.Forms.Button();
            this.getTeacherNamesTableAdapter = new SchoolJournalGUI.schooljournalDataSetTableAdapters.getTeacherNamesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getTeacherNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooljournalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose teacher:";
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getTeacherNamesBindingSource, "Name", true));
            this.comboBoxTeachers.DataSource = this.getTeacherNamesBindingSource;
            this.comboBoxTeachers.DisplayMember = "Name";
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(111, 25);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(294, 21);
            this.comboBoxTeachers.TabIndex = 3;
            this.comboBoxTeachers.ValueMember = "Name";
            // 
            // getTeacherNamesBindingSource
            // 
            this.getTeacherNamesBindingSource.DataMember = "getTeacherNames";
            this.getTeacherNamesBindingSource.DataSource = this.schooljournalDataSet;
            // 
            // schooljournalDataSet
            // 
            this.schooljournalDataSet.DataSetName = "schooljournalDataSet";
            this.schooljournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(166, 69);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(141, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // getTeacherNamesTableAdapter
            // 
            this.getTeacherNamesTableAdapter.ClearBeforeFill = true;
            // 
            // ManageTeacherGroupsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 120);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.label3);
            this.Name = "ManageTeacherGroupsDialog";
            this.Text = "Choose teacher - School Journal";
            this.Load += new System.EventHandler(this.ManageTeacherGroupsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTeacherNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooljournalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Button btnGo;
        private schooljournalDataSet schooljournalDataSet;
        private System.Windows.Forms.BindingSource getTeacherNamesBindingSource;
        private schooljournalDataSetTableAdapters.getTeacherNamesTableAdapter getTeacherNamesTableAdapter;
    }
}