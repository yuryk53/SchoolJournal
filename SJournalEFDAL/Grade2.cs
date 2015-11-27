using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public partial class Grade
    {
        public override string ToString()
        {
            return string.Format("{0}{1}", this.GradeNo, this.Section);
        }
    }
}
