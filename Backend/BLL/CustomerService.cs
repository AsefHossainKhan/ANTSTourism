using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerService
    {
        //Get All Customer List
        public static List<UserModel> GetCustomers()
        {
            var customers = CustomerRepo.GetCustomers();
            var data = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(customers);
            return data;
        }

        //Get Customer Details
        public static CustomerDetails GetCustomerDetails(int id)
        {
            var c = CustomerRepo.GetCustomerDetails(id);
            var customerdetails = AutoMapper.Mapper.Map<User, CustomerDetails>((User)c);
            return customerdetails;
        }

        //Get Package Details
        public static List<PackageModel> GetPackages()
        {
            var packages = CustomerRepo.GetPackages();
            var data = AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(packages);
            return data;
        }

        //Get All Notices
        public static List<NoticeModel> GetNotices()
        {
            var notices = CustomerRepo.GetNotices();
            var data = AutoMapper.Mapper.Map<List<Notice>, List<NoticeModel>>(notices);
            return data;
        }

        //Get All Blogs
        public static List<BlogsModel> GetBlogs()
        {
            var blogs = CustomerRepo.GetBlogs();
            var data = AutoMapper.Mapper.Map<List<Blog>, List<BlogsModel>>((List<Blog>)blogs);
            return data; ;
        }

        public static BlogsModel AddBlogs(BlogsModel blogs)
        {
            var b = AutoMapper.Mapper.Map<BlogsModel, Blog>(blogs);
            var data = CustomerRepo.AddBlogs(b);
            return AutoMapper.Mapper.Map<Blog, BlogsModel>((Blog)data);
        }

        public static BlogsModel EditBlogs(BlogsModel blogs)
        {
            var b = AutoMapper.Mapper.Map<BlogsModel, Blog>(blogs);
            var data = CustomerRepo.EditBlogs(b);
            return AutoMapper.Mapper.Map<Blog, BlogsModel>((Blog)data);
        }

        public static BlogsModel DeleteBlogs(int id)
        {
            var data = CustomerRepo.DeleteBlogs(id);
            return AutoMapper.Mapper.Map<Blog, BlogsModel>((Blog)data);
        }

        //Get Order data
        public static List<OrderModel> GetAllOrders(int id)
        {
            var orders = CustomerRepo.GetAllOrders(id);
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
            return data;
        }


        public static OrderModel GetOrders(int id)
        {
            var order = CustomerRepo.GetOrders(id);
            return AutoMapper.Mapper.Map<Order, OrderModel>(order);
        }

        public static OrderModel AddOrder(OrderModel order, int id)
        {
            var o = AutoMapper.Mapper.Map<OrderModel, Order>(order);
            var data = CustomerRepo.AddOrder(o, id);
            return AutoMapper.Mapper.Map<Order, OrderModel>((Order)data);
        }

        public static OrderModel CancelOrder(int id, int orderid)
        {
            var data = CustomerRepo.CancelOrder(id, orderid);
            return AutoMapper.Mapper.Map<Order, OrderModel>((Order)data);
        }
    }
}
