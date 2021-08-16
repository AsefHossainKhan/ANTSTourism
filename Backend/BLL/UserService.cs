using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class UserService
    {
        public static List<UserModel> GetAllUsers()
        {
            var users = UserRepo.GetAllUsers();
            return AutoMapper.Mapper.Map<List<User>, List<UserModel>>(users);
        }

        public static List<UserModel> GetUser()
        {
            var userw = UserRepo.GetUser();
            return AutoMapper.Mapper.Map<List<User>, List<UserModel>>(userw);
        }
        public static void EditUser(UserModel usr)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(usr);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            UserRepo.EditUser(data);
        }
    }
}
