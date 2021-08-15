using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NoticeRepo
    {
        static ANTSEntities context;
        static NoticeRepo()
        {
            context = new ANTSEntities();
        }

        public static List<Notice> GetAllNotices()
        {
            return context.Notices.ToList();
        }

        public static Notice GetNotice(int id)
        {
            return context.Notices.FirstOrDefault(e => e.noticeid == id);
        }

        public static Notice AddNotice(Notice n)
        {
            context.Notices.Add(n);
            context.SaveChanges();
            return n;
        }

        public static Notice EditNotice(Notice n)
        {
            var notice = context.Notices.FirstOrDefault(e => e.noticeid == n.noticeid);
            context.Entry(notice).CurrentValues.SetValues(n);
            context.SaveChanges();
            return notice;
        }

        public static Notice DeleteNotice(int id)
        {
            var notice = context.Notices.FirstOrDefault(e => e.noticeid == id);
            context.Notices.Remove(notice);
            context.SaveChanges();
            return notice;
        }
    }
}
