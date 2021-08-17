using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BlogsService
    {
        public static BlogsModel AddBlogs(BlogsModel blogs)
        {
            var b = AutoMapper.Mapper.Map<BlogsModel, Blog>(blogs);
            var data = BlogsRepo.AddBlogs(b);
            return AutoMapper.Mapper.Map<Blog, BlogsModel>((Blog)data);
        }

        public static BlogsModel EditBlogs(BlogsModel blogs)
        {
            var b = AutoMapper.Mapper.Map<BlogsModel, Blog>(blogs);
            var data = BlogsRepo.EditBlogs(b);
            return AutoMapper.Mapper.Map<Blog, BlogsModel>((Blog)data);
        }

        public static BlogsModel DeleteBlogs(int id)
        {
            var data = BlogsRepo.DeleteBlogs(id);
            return AutoMapper.Mapper.Map<Blog, BlogsModel>((Blog)data);
        }

    }
}
