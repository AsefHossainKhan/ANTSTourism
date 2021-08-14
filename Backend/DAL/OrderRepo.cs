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

        public static List<Order> GetAllOrders(int id)
        {
            return context.Orders.Where(e => e.customerid == id).ToList();
        }

     
        public static Order GetOrders(int id)
        {
            return context.Orders.FirstOrDefault(e => e.orderid == id);
        }
    }
}
