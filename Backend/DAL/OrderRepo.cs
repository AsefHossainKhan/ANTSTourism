using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static ANTSEntities context;
        static OrderRepo()
        {
            context = new ANTSEntities();
        }
        public static List<Order> GetOrder()
        {
            var list = (from p in context.Orders
                        where p.sellerid == 8
                        select p).ToList();
            return list;
        }
        public static List<Order> GetSearchOrder(string search)
        {
            var list = (from p in context.Orders
                        where p.ordername.Contains(search)
                        select p).ToList();
            return list;
        }
        public static void EditStatus(int id, string status)
        {
            var oldp = context.Orders.FirstOrDefault(e => e.orderid == id);
            oldp.status = status;

            context.SaveChanges();
        }
    }
}
