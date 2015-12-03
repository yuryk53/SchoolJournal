﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SJournalEFDAL;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace SchoolJournalGUI
{
    public partial class ManageStudentsWindow : Form
    {
        public ManageStudentsWindow()
        {
            InitializeComponent();
        }

        private void ManageStudentsWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schooljournalDataSet.getDistinctGrades' table. You can move, or remove it, as needed.
            this.getDistinctGradesTableAdapter.Fill(this.schooljournalDataSet.getDistinctGrades);
            // TODO: This line of code loads data into the 'schooljournalDataSet.studentsList' table. You can move, or remove it, as needed.
            this.studentsListTableAdapter.Fill(this.schooljournalDataSet.studentsList);


            //using (SchoolJournalEntities context = new SchoolJournalEntities())
            //{
            //    context.studentsList.Load();
            //    students = context.studentsList.Local.ToList();
            //    dataGridStudents.DataSource = students;
            //}
            //bind binging navigator to data grid
            var bs = new BindingSource();
            bs.DataSource = dataGridStudents.DataSource;
            bindingNavigator1.BindingSource = bs;
            dataGridStudents.DataSource = bs;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var IDs = from user in context.Users select user.UserID;
                for (int i = 0; i < dataGridStudents.Rows.Count-1; i++)
                {
                    if (!IDs.Contains(int.Parse(dataGridStudents["StudentID", i].Value.ToString())))
                    {
                        try
                        {
                            AddNewStudent(i);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        DateTime dateOfJoin;
                        DateTime? parsedDateOfJoin = null;
                        bool success = DateTime.TryParse(dataGridStudents["Date_of_join", i].Value.ToString(), out dateOfJoin);
                        if (success)
                            parsedDateOfJoin = dateOfJoin;
                        //check all fields and save
                        StudentDAL.UpdateStudent(int.Parse(dataGridStudents["StudentID", i].Value.ToString()),
                                dataGridStudents["First_name", i].Value.ToString(),
                                dataGridStudents["Last_name", i].Value.ToString(),
                                dataGridStudents["Patronymic", i].Value.ToString(),
                                null,
                                dataGridStudents["Email", i].Value.ToString(),
                                dataGridStudents["Password", i].Value.ToString(),
                                null,
                                dataGridStudents["Grade", i].EditedFormattedValue.ToString(),
                                parsedDateOfJoin);
                    }
                }
            }
        }

        private void AddNewStudent(int rowNumber)
        {
           dataGridStudents["StudentID", rowNumber].Value =
               StudentDAL.AddNewStudent(dataGridStudents["First_name", rowNumber].Value.ToString(),
                                dataGridStudents["Last_name", rowNumber].Value.ToString(),
                                dataGridStudents["Patronymic", rowNumber].Value.ToString(),
                                null,
                                dataGridStudents["Email", rowNumber].Value.ToString(),
                                dataGridStudents["Password", rowNumber].Value.ToString(),
                                null,
                                dataGridStudents["Grade", rowNumber].EditedFormattedValue.ToString()
                                );
        }

        private void dataGridStudents_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int rowIndex = e.Row.Index-1;
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                int lastID = 0;
                try
                {
                    lastID = Math.Max(
                        int.Parse(dataGridStudents["StudentID", dataGridStudents.Rows.Count - 3].Value.ToString()),
                        (int)(from u in context.Users select u.UserID).Max());
                }
                catch 
                { }
                dataGridStudents["StudentID", rowIndex].Value = lastID + 1;
            }
                                
        }

      

        private void toolStripDeleteRecord_Click(object sender, EventArgs e)
        {
            //delete student with such student id
            if (dataGridStudents.SelectedRows.Count > 1)
            {
                MessageBox.Show("You should select only one row!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int selectedRow = dataGridStudents.CurrentCell.RowIndex;
                int studentID = int.Parse(
                    dataGridStudents.Rows[selectedRow].Cells[0].Value.ToString());
                if (
                    MessageBox.Show(
                    string.Format("Do you really want to delete student {0} {1}?",
                    dataGridStudents["Last_name", selectedRow].Value.ToString(),
                    dataGridStudents["First_name", selectedRow].Value.ToString()), "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    UsersDAL.DeleteUser(studentID);
                    dataGridStudents.Rows.Remove(dataGridStudents.Rows[selectedRow]);
                }
                else return;
            }
        }


    }
}
