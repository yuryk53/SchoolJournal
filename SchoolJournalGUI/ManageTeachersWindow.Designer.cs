namespace SchoolJournalGUI
{
    partial class ManageTeachersWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTeachersWindow));
            this.schooljournalDataSet = new SchoolJournalGUI.schooljournalDataSet();
            this.teachersListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersListTableAdapter = new SchoolJournalGUI.schooljournalDataSetTableAdapters.teachersListTableAdapter();
            this.tableAdapterManager = new SchoolJournalGUI.schooljournalDataSetTableAdapters.TableAdapterManager();
            this.teachersListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveChanges = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.teachersListDataGridView = new System.Windows.Forms.DataGridView();
            this.teacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSavedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.schooljournalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersListBindingNavigator)).BeginInit();
            this.teachersListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersListDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schooljournalDataSet
            // 
            this.schooljournalDataSet.DataSetName = "schooljournalDataSet";
            this.schooljournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersListBindingSource
            // 
            this.teachersListBindingSource.DataMember = "teachersList";
            this.teachersListBindingSource.DataSource = this.schooljournalDataSet;
            // 
            // teachersListTableAdapter
            // 
            this.teachersListTableAdapter.ClearBeforeFill = true;
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
            // teachersListBindingNavigator
            // 
            this.teachersListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teachersListBindingNavigator.BindingSource = this.teachersListBindingSource;
            this.teachersListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teachersListBindingNavigator.DeleteItem = null;
            this.teachersListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripButtonSaveChanges,
            this.toolStripButtonDeleteRecord});
            this.teachersListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teachersListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teachersListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teachersListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teachersListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teachersListBindingNavigator.Name = "teachersListBindingNavigator";
            this.teachersListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teachersListBindingNavigator.Size = new System.Drawing.Size(878, 25);
            this.teachersListBindingNavigator.TabIndex = 0;
            this.teachersListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // toolStripButtonSaveChanges
            // 
            this.toolStripButtonSaveChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveChanges.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveChanges.Image")));
            this.toolStripButtonSaveChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveChanges.Name = "toolStripButtonSaveChanges";
            this.toolStripButtonSaveChanges.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveChanges.Text = "Save changes";
            this.toolStripButtonSaveChanges.Click += new System.EventHandler(this.toolStripButtonSaveChanges_Click);
            // 
            // toolStripButtonDeleteRecord
            // 
            this.toolStripButtonDeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteRecord.Image")));
            this.toolStripButtonDeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteRecord.Name = "toolStripButtonDeleteRecord";
            this.toolStripButtonDeleteRecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteRecord.Text = "Delete record";
            this.toolStripButtonDeleteRecord.Click += new System.EventHandler(this.toolStripButtonDeleteRecord_Click);
            // 
            // teachersListDataGridView
            // 
            this.teachersListDataGridView.AutoGenerateColumns = false;
            this.teachersListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherID,
            this.lastName,
            this.firstName,
            this.patronymic,
            this.dateOfBirth,
            this.email,
            this.password,
            this.phone,
            this.category,
            this.specialization});
            this.teachersListDataGridView.DataSource = this.teachersListBindingSource;
            this.teachersListDataGridView.Location = new System.Drawing.Point(0, 28);
            this.teachersListDataGridView.Name = "teachersListDataGridView";
            this.teachersListDataGridView.Size = new System.Drawing.Size(878, 384);
            this.teachersListDataGridView.TabIndex = 1;
            this.teachersListDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.teachersListDataGridView_CellEndEdit);
            this.teachersListDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.teachersListDataGridView_UserAddedRow);
            // 
            // teacherID
            // 
            this.teacherID.DataPropertyName = "Teacher ID";
            this.teacherID.HeaderText = "Teacher ID";
            this.teacherID.Name = "teacherID";
            this.teacherID.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "Last name";
            this.lastName.HeaderText = "Last name";
            this.lastName.Name = "lastName";
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "First name";
            this.firstName.HeaderText = "First name";
            this.firstName.Name = "firstName";
            // 
            // patronymic
            // 
            this.patronymic.DataPropertyName = "Patronymic";
            this.patronymic.HeaderText = "Patronymic";
            this.patronymic.Name = "patronymic";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataPropertyName = "Date of birth";
            this.dateOfBirth.HeaderText = "Date of birth";
            this.dateOfBirth.Name = "dateOfBirth";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            // 
            // category
            // 
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // specialization
            // 
            this.specialization.DataPropertyName = "Specialization";
            this.specialization.HeaderText = "Specialization";
            this.specialization.Name = "specialization";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSavedStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSavedStatus
            // 
            this.toolStripSavedStatus.Name = "toolStripSavedStatus";
            this.toolStripSavedStatus.Size = new System.Drawing.Size(115, 17);
            this.toolStripSavedStatus.Text = "toolStripSavedStatus";
            // 
            // ManageTeachersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.teachersListDataGridView);
            this.Controls.Add(this.teachersListBindingNavigator);
            this.Name = "ManageTeachersWindow";
            this.Text = "Manage Teachers - School Journal";
            this.Load += new System.EventHandler(this.ManageTeachersWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schooljournalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersListBindingNavigator)).EndInit();
            this.teachersListBindingNavigator.ResumeLayout(false);
            this.teachersListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersListDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schooljournalDataSet schooljournalDataSet;
        private System.Windows.Forms.BindingSource teachersListBindingSource;
        private schooljournalDataSetTableAdapters.teachersListTableAdapter teachersListTableAdapter;
        private schooljournalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teachersListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView teachersListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveChanges;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteRecord;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSavedStatus;
    }
}