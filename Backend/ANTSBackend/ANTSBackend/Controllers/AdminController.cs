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
    public class AdminController : ApiController
    {
        [Route("api/Users/GetAll")]
        [HttpGet]
        public List<UserModel> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }
    }
}
