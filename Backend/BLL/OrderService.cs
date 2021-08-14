using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        public static List<OrderModel> GetAllOrders(int id)
        {
            var orders = OrderRepo.GetAllOrders(id);
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
            return data;
        }


        public static OrderModel GetOrders(int id)
        {
            var order = OrderRepo.GetOrders(id);
            return AutoMapper.Mapper.Map<Order, OrderModel>(order);
        }
    }
}
