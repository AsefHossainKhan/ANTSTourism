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
    public class UserProfileController : ApiController
    {
        [Route("api/User/Get")]
        [HttpGet]
        public UserModel GetUser(int id)
        {
            return UserService.GetUser(id);
        }
        [Route("api/User/edit")]
        [HttpPost]
        public void Edit(UserModel prdct)
        {
            UserService.EditUser(prdct);
        }

        public class LoginController : ApiController
        {
            [Route("api/Login/{mail}/{pass}")]
            [HttpGet]
            public UserModel Login(string mail, string pass)
            {
                return UserService.GetUserlogin(mail, pass);
            }
        }
    }
}
