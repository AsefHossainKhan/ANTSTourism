using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        static ANTSEntities context;
        static UserRepo()
        {
            context = new ANTSEntities();
        }

        public static List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }
        public static List<User> GetUser()
        {
            //have to use session
            return context.Users.Where(e => e.userid == 8).ToList();
        }
        public static void EditUser(User d)
        {
            //have to use session
            var oldp = context.Users.FirstOrDefault(e => e.userid == 8);
            oldp.name = d.name;
            oldp.password = d.password;
            oldp.email = d.email;
            oldp.phone = d.phone;
            context.SaveChanges();
        }
    }
}
