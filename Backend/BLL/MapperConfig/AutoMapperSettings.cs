using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using BEL;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<UserModel, User>();
            CreateMap<NoticeModel, Notice>();
            CreateMap<RatingModel, Rating>();
            CreateMap<VoucherModel, Voucher>();
            //CreateMap<ProductModel, product>();
            //CreateMap<OrderModel, order>();
            //CreateMap<ProductOrderModel, productorder>();

            //CreateMap<DepartmentModel, Department>().ForMember(e=>e.Students, d=>d.Ignore().ForMember(..));
        }
    }
}
