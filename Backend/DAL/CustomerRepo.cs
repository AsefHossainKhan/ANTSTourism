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

        //Get All customers
        public static List<User> GetCustomers()
        {
            var data = context.Users.Where(e => e.usertype == "Customer");
            return data.ToList();
        }

        //Get customer details
        public static object GetCustomerDetails(int id)
        {
            return context.Users.FirstOrDefault(e => e.userid == id); ;
        }

        //Get all packages
        public static List<Package> GetPackages()
        {
            var data = context.Packages;
            return data.ToList();
        }

        //Get All notices
        public static List<Notice> GetNotices()
        {
            var data = context.Notices;
            return data.ToList();
        }

        //Get all blogs
        public static object GetBlogs()
        {
            var data = context.Blogs;
            return data.ToList(); ;
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

        //Get orders
        public static List<Order> GetAllOrders(int id)
        {
            return context.Orders.Where(e => e.customerid == id).ToList();
        }


        public static Order GetOrders(int id)
        {
            return context.Orders.FirstOrDefault(e => e.orderid == id);
        }

        public static Order AddOrder(Order o, int id)
        {
            o.createdat = DateTime.Now;
            o.customerid = id;
            o.status = "unsold";
            context.Orders.Add(o);
            context.SaveChanges();
            return o; ;
        }

        public static object CancelOrder(int id, int orderid)
        {
            var data = context.Orders.FirstOrDefault(e => e.orderid == orderid);
            data.status = "cancelled";
            context.SaveChanges();
            return data; ;
        }
    }
}
