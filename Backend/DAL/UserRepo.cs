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

        public static List<User> GetSearchUsers(string search)
        {
            var list = (from p in context.Users
                        where p.name.Contains(search)
                        select p).ToList();
            return list;
        }

        public static User GetUser(int id)
        {
            return context.Users.FirstOrDefault(e => e.userid == id);
        }

        public static User AddUser(User u)
        {
            context.Users.Add(u);
            context.SaveChanges();
            return u;
        }

        public static User EditUser(User u)
        {
            var user = context.Users.FirstOrDefault(e => e.userid == u.userid);
            context.Entry(user).CurrentValues.SetValues(u);
            context.SaveChanges();
            return user;
        }

        public static User DeleteUser(int id)
        {
            var user = context.Users.FirstOrDefault(e => e.userid == id);
            context.Users.Remove(user);
            context.SaveChanges();
            return user;
        }
    }
}
