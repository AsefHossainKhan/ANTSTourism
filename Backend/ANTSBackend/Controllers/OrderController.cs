using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;


namespace ANTSBackend.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/GetAll")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {
            return OrderService.GetOrderList();
        }

        [Route("api/Order/Search/{search}")]
        [HttpGet]
        public List<OrderModel> GetSearchOrder(string search)
        {
            return OrderService.GetSearchOrder(search);
        }

        [Route("api/Order/Status/{id}/{status}")]
        [HttpGet]
        public void Edit(int id, string status)
        {
            OrderService.EditStatus(id, status);
        }
    }
}
