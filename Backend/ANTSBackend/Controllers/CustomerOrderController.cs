using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ANTSBackend.Controllers
{
    public class CustomerOrderController : ApiController
    {
        [Route("api/CustomerOrder/{id}/GetAll")]
        [HttpGet]
        public List<OrderModel> GetAllOrders(int id)
        {
            return OrderService.GetAllOrders(id);
        }

        [Route("api/Order/{id}")]
        [HttpGet]
        public OrderModel GetOrders(int id)
        {
            return OrderService.GetOrders(id);
        }

        [Route("api/{id}/Order/add")]
        [HttpPost]

        public OrderModel AddOrder(OrderModel order, int id)
        {
            return OrderService.AddOrder(order, id);
        }

        [Route("api/{id}/Order/cancel/{orderid}")]
        [HttpGet]
        public OrderModel CancelOrder(int id, int orderid)
        {
            return OrderService.CancelOrder(id,orderid);
        }
    }
}
