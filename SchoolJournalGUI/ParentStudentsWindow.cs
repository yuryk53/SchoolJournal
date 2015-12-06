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
    public partial class ParentStudentsWindow : Form
    {
        int ParentID { get; set; }
        DataTable students = null;
        public ParentStudentsWindow(int parentID)
        {
            InitializeComponent();
            this.ParentID = parentID;
        }

        private void ParentStudentsWindow_Load(object sender, EventArgs e)
        {
            students = ParentDAL.GetParentStudents(this.ParentID);

            //bind binging navigator to data grid
            var bs = new BindingSource();
            bs.DataSource = students.DefaultView;
            bindingNavigator1.BindingSource = bs;
            this.studentsDataGridView.DataSource = bs;

            this.toolStripParentID.Text = "Parent ID: " + this.ParentID;

        }
    }
}
