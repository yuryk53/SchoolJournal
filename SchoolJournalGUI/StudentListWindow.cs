using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SJournalEFDAL;

namespace SchoolJournalGUI
{
    public partial class StudentListWindow : Form
    {
        int TeacherID { get; set; }
        public StudentListWindow(int teacherID)
        {
            InitializeComponent();
            TeacherID = teacherID;
        }

        private void StudentListWindow_Load(object sender, EventArgs e)
        {
            DataTable dt = TeacherDAL.GetTeacherStudents(TeacherID);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Update();

            //bind binging navigator to data grid
            var bs = new BindingSource();
            bs.DataSource = dt.DefaultView;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;

            this.toolStripTeacherID.Text = "TeacherID: " + TeacherID.ToString();
        }
    }
}
