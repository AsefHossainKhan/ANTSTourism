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
        public static List<UserModel> GetCustomers()
        {
            var customers = CustomerRepo.GetCustomers();
            var data = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(customers);
            return data;
        }

        public static CustomerDetails GetCustomerDetails(int id)
        {
            var c = CustomerRepo.GetCustomerDetails(id);
            var customerdetails = AutoMapper.Mapper.Map<User, CustomerDetails>((User)c);
            return customerdetails;
        }

        public static List<PackageModel> GetPackages()
        {
            var packages = CustomerRepo.GetPackages();
            var data = AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(packages);
            return data;
        }

        public static List<NoticeModel> GetNotices()
        {
            var notices = CustomerRepo.GetNotices();
            var data = AutoMapper.Mapper.Map<List<Notice>, List<NoticeModel>>(notices);
            return data;
        }

        public static List<BlogsModel> GetBlogs()
        {
            var blogs = CustomerRepo.GetBlogs();
            var data = AutoMapper.Mapper.Map<List<Blog>, List<BlogsModel>>((List<Blog>)blogs);
            return data; ;
        }
    }
}
