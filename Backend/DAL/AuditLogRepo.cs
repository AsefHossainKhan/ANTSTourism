using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuditLogRepo
    {
        static ANTSEntities context;
        static AuditLogRepo()
        {
            context = new ANTSEntities();
        }

        public static Auditlog AddAuditLog(Auditlog a)
        {
            context.Auditlogs.Add(a);
            context.SaveChanges();
            return a;
        }

        public static List<Auditlog> GetAllAuditLogs()
        {
            return context.Auditlogs.ToList();
        }



    }
}
