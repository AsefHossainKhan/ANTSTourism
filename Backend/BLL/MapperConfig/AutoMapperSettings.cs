using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL;
using DAL;
using BEL;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            //CreateMap<CategoryModel, category>();
            CreateMap<PackageModel, Package>();
            //CreateMap<OrderModel, order>();
            //CreateMap<ProductOrderModel, productorder>();

            //CreateMap<DepartmentModel, Department>().ForMember(e=>e.Students, d=>d.Ignore().ForMember(..));
        }
    }
}
