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
    }
}
