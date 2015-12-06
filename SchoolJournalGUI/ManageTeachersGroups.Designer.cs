namespace SchoolJournalGUI
{
    partial class ManageTeachersGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeachersGroups));
            this.teachers_groupsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.teachers_groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schooljournalDataSet = new SchoolJournalGUI.schooljournalDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveChanges = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStudentToGroup = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveStudentFromGroup = new System.Windows.Forms.ToolStripButton();
            this.GroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Grade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.getDistinctGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.Group_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getGroupStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripIsSaved = new System.Windows.Forms.ToolStripStatusLabel();
            this.teachers_groupsTableAdapter = new SchoolJournalGUI.schooljournalDataSetTableAdapters.teachers_groupsTableAdapter();
            this.tableAdapterManager = new SchoolJournalGUI.schooljournalDataSetTableAdapters.TableAdapterManager();
            this.getGroupStudentsTableAdapter = new SchoolJournalGUI.schooljournalDataSetTableAdapters.getGroupStudentsTableAdapter();
            this.subjectTableAdapter = new SchoolJournalGUI.schooljournalDataSetTableAdapters.subjectTableAdapter();
            this.getDistinctGradesTableAdapter = new SchoolJournalGUI.schooljournalDataSetTableAdapters.getDistinctGradesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_groupsBindingNavigator)).BeginInit();
            this.teachers_groupsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooljournalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDistinctGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGroupStudentsBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teachers_groupsBindingNavigator
            // 
            this.teachers_groupsBindingNavigator.AddNewItem = null;
            this.teachers_groupsBindingNavigator.BindingSource = this.teachers_groupsBindingSource;
            this.teachers_groupsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teachers_groupsBindingNavigator.DeleteItem = null;
            this.teachers_groupsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnSaveChanges,
            this.toolStripSeparator1,
            this.btnAddStudentToGroup,
            this.btnRemoveStudentFromGroup});
            this.teachers_groupsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teachers_groupsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teachers_groupsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teachers_groupsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teachers_groupsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teachers_groupsBindingNavigator.Name = "teachers_groupsBindingNavigator";
            this.teachers_groupsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teachers_groupsBindingNavigator.Size = new System.Drawing.Size(952, 25);
            this.teachers_groupsBindingNavigator.TabIndex = 0;
            this.teachers_groupsBindingNavigator.Text = "bindingNavigator1";
            // 
            // teachers_groupsBindingSource
            // 
            this.teachers_groupsBindingSource.DataMember = "teachers_groups";
            this.teachers_groupsBindingSource.DataSource = this.schooljournalDataSet;
            // 
            // schooljournalDataSet
            // 
            this.schooljournalDataSet.DataSetName = "schooljournalDataSet";
            this.schooljournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChanges.Image")));
            this.btnSaveChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(23, 22);
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddStudentToGroup
            // 
            this.btnAddStudentToGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudentToGroup.Image")));
            this.btnAddStudentToGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddStudentToGroup.Name = "btnAddStudentToGroup";
            this.btnAddStudentToGroup.Size = new System.Drawing.Size(141, 22);
            this.btnAddStudentToGroup.Text = "Add student to group";
            this.btnAddStudentToGroup.Click += new System.EventHandler(this.btnAddStudentToGroup_Click);
            // 
            // btnRemoveStudentFromGroup
            // 
            this.btnRemoveStudentFromGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveStudentFromGroup.Image")));
            this.btnRemoveStudentFromGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveStudentFromGroup.Name = "btnRemoveStudentFromGroup";
            this.btnRemoveStudentFromGroup.Size = new System.Drawing.Size(177, 22);
            this.btnRemoveStudentFromGroup.Text = "Remove student from group";
            this.btnRemoveStudentFromGroup.Click += new System.EventHandler(this.btnRemoveStudentFromGroup_Click);
            // 
            // GroupsDataGridView
            // 
            this.GroupsDataGridView.AutoGenerateColumns = false;
            this.GroupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.TeacherID,
            this.LastName,
            this.FirstName,
            this.Patronymic,
            this.Subject,
            this.Grade,
            this.Description});
            this.GroupsDataGridView.DataSource = this.teachers_groupsBindingSource;
            this.GroupsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.GroupsDataGridView.Name = "GroupsDataGridView";
            this.GroupsDataGridView.Size = new System.Drawing.Size(950, 195);
            this.GroupsDataGridView.TabIndex = 1;
            this.GroupsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GroupsDataGridView_CellBeginEdit);
            this.GroupsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupsDataGridView_CellEndEdit);
            this.GroupsDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.GroupsDataGridView_UserAddedRow);
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "Group ID";
            this.GroupID.HeaderText = "Group ID";
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            // 
            // TeacherID
            // 
            this.TeacherID.DataPropertyName = "Teacher ID";
            this.TeacherID.HeaderText = "Teacher ID";
            this.TeacherID.Name = "TeacherID";
            this.TeacherID.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Last name";
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "First name";
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            // 
            // Patronymic
            // 
            this.Patronymic.DataPropertyName = "Patronymic";
            this.Patronymic.HeaderText = "Patronymic";
            this.Patronymic.Name = "Patronymic";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.DataSource = this.subjectBindingSource;
            this.Subject.DisplayMember = "title";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Subject.ValueMember = "title";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.schooljournalDataSet;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.DataSource = this.getDistinctGradesBindingSource;
            this.Grade.DisplayMember = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Grade.ValueMember = "Grade";
            // 
            // getDistinctGradesBindingSource
            // 
            this.getDistinctGradesBindingSource.DataMember = "getDistinctGrades";
            this.getDistinctGradesBindingSource.DataSource = this.schooljournalDataSet;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "description";
            this.Description.Name = "Description";
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group_ID,
            this.Last_Name,
            this.First_Name,
            this.Student_ID});
            this.studentsDataGridView.DataSource = this.getGroupStudentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(1, 229);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.Size = new System.Drawing.Size(950, 220);
            this.studentsDataGridView.TabIndex = 3;
            this.studentsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGridView_CellEndEdit);
            this.studentsDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.studentsDataGridView_UserAddedRow);
            this.studentsDataGridView.Enter += new System.EventHandler(this.studentsDataGridView_Enter);
            // 
            // Group_ID
            // 
            this.Group_ID.DataPropertyName = "Group ID";
            this.Group_ID.DataSource = this.teachers_groupsBindingSource;
            this.Group_ID.DisplayMember = "Group ID";
            this.Group_ID.HeaderText = "Group ID";
            this.Group_ID.Name = "Group_ID";
            this.Group_ID.ReadOnly = true;
            this.Group_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Group_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Group_ID.ValueMember = "Group ID";
            // 
            // Last_Name
            // 
            this.Last_Name.DataPropertyName = "Last Name";
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            // 
            // First_Name
            // 
            this.First_Name.DataPropertyName = "First Name";
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            // 
            // Student_ID
            // 
            this.Student_ID.DataPropertyName = "Student ID";
            this.Student_ID.HeaderText = "Student ID";
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            // 
            // getGroupStudentsBindingSource
            // 
            this.getGroupStudentsBindingSource.DataMember = "getGroupStudents";
            this.getGroupStudentsBindingSource.DataSource = this.schooljournalDataSet;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripIsSaved});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripIsSaved
            // 
            this.toolStripIsSaved.Name = "toolStripIsSaved";
            this.toolStripIsSaved.Size = new System.Drawing.Size(86, 17);
            this.toolStripIsSaved.Text = "Changes saved";
            // 
            // teachers_groupsTableAdapter
            // 
            this.teachers_groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.gradeTableAdapter = null;
            this.tableAdapterManager.groupTableAdapter = null;
            this.tableAdapterManager.lesson_studentTableAdapter = null;
            this.tableAdapterManager.lessonTableAdapter = null;
            this.tableAdapterManager.marksTableAdapter = null;
            this.tableAdapterManager.parent_studentTableAdapter = null;
            this.tableAdapterManager.parentTableAdapter = null;
            this.tableAdapterManager.student_groupTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.subjectTableAdapter = null;
            this.tableAdapterManager.teacher_lessonTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SchoolJournalGUI.schooljournalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // getGroupStudentsTableAdapter
            // 
            this.getGroupStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // getDistinctGradesTableAdapter
            // 
            this.getDistinctGradesTableAdapter.ClearBeforeFill = true;
            // 
            // ManageTeachersGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 475);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.GroupsDataGridView);
            this.Controls.Add(this.teachers_groupsBindingNavigator);
            this.Name = "ManageTeachersGroups";
            this.Text = "Manage Groups - School Journal";
            this.Load += new System.EventHandler(this.ManageTeachersGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachers_groupsBindingNavigator)).EndInit();
            this.teachers_groupsBindingNavigator.ResumeLayout(false);
            this.teachers_groupsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooljournalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDistinctGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGroupStudentsBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schooljournalDataSet schooljournalDataSet;
        private System.Windows.Forms.BindingSource teachers_groupsBindingSource;
        private schooljournalDataSetTableAdapters.teachers_groupsTableAdapter teachers_groupsTableAdapter;
        private schooljournalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teachers_groupsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView GroupsDataGridView;
        private System.Windows.Forms.BindingSource getGroupStudentsBindingSource;
        private schooljournalDataSetTableAdapters.getGroupStudentsTableAdapter getGroupStudentsTableAdapter;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.ToolStripButton btnSaveChanges;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripIsSaved;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private schooljournalDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource getDistinctGradesBindingSource;
        private schooljournalDataSetTableAdapters.getDistinctGradesTableAdapter getDistinctGradesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewComboBoxColumn Subject;
        private System.Windows.Forms.DataGridViewComboBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ToolStripButton btnAddStudentToGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRemoveStudentFromGroup;
        private System.Windows.Forms.DataGridViewComboBoxColumn Group_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
    }
}