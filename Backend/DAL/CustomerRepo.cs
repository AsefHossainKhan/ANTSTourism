using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo
    {
        static ANTSEntities context;
        static CustomerRepo()
        {
            context = new ANTSEntities();
        }

        public static List<User> GetCustomers()
        {
            var data = context.Users.Where(e => e.usertype == "Customer");
            return data.ToList();
        }

        public static object GetCustomerDetails(int id)
        {
            return context.Users.FirstOrDefault(e => e.userid == id); ;
        }

        public static List<Package> GetPackages()
        {
            var data = context.Packages;
            return data.ToList();
        }

        public static List<Notice> GetNotices()
        {
            var data = context.Notices;
            return data.ToList();
        }

        public static object GetBlogs()
        {
            var data = context.Blogs;
            return data.ToList(); ;
        }
    }
}
