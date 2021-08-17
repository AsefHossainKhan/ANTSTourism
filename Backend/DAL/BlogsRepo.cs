using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogsRepo
    {
        static ANTSEntities context;
        static BlogsRepo()
        {
            context = new ANTSEntities();
        }
        public static Blog AddBlogs(Blog b)
        {
            context.Blogs.Add(b);
            context.SaveChanges();
            return b;
        }

        public static Blog EditBlogs(Blog b)
        {
            var data = context.Blogs.FirstOrDefault(e => e.blogid == b.blogid);
            context.Entry(data).CurrentValues.SetValues(b);
            context.SaveChanges();
            return data; 
        }

        public static Blog DeleteBlogs(int id)
        {
            var data = context.Blogs.FirstOrDefault(e => e.blogid == id);
            context.Blogs.Remove(data);
            context.SaveChanges();
            return data; 
        }
    }
}
