using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolJournalGUI
{
    public partial class DateIntervalDialog : Form
    {
        public DateTime IntervalStart { get; set; }
        public DateTime IntervalEnd { get; set; }
        public DateIntervalDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.dateTimePickerStart.Value > this.dateTimePickerEnd.Value)
            {
                MessageBox.Show("Incorrect date interval! Start date has to be less than end date!", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.IntervalStart = this.dateTimePickerStart.Value;
            this.IntervalEnd = this.dateTimePickerEnd.Value;

            this.Close();
        }

        private void DateIntervalDialog_Load(object sender, EventArgs e)
        {
            this.dateTimePickerStart.Value = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            this.dateTimePickerEnd.Value = DateTime.Now;
        }
    }
}
