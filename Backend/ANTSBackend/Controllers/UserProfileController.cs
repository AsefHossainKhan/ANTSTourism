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
        public List<UserModel> GetUser()
        {
            return UserService.GetUser();
        }
        [Route("api/User/edit")]
        [HttpPost]
        public void Edit(UserModel prdct)
        {
            UserService.EditUser(prdct);
        }
    }
}
