using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public class AdminDAL
    {
        public static AdminInfo GetAdmin(int adminID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var admins = from adm in context.Admins where adm.AdminID == adminID select adm;
                return new AdminInfo(admins.First());
            }
        }
    }
}
