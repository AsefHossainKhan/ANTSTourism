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
    public class PackageController : ApiController
    {
        [Route("api/Package/GetAll")]
        [HttpGet]
        public List<PackageModel> GetAllCategorys()
        {
            return PackageService.GetProductList();
        }

        [Route("api/Package/Add")]
        [HttpPost]
        public void Add(PackageModel prdct)
        {
            PackageService.AddProduct(prdct);
        }

        [Route("api/Package/edit/{id}")]
        [HttpGet]
        public List<PackageModel> GetPackage(int id)
        {
            return PackageService.GetPackage(id);
        }
        [Route("api/Package/edit/{id}")]
        [HttpPost]
        public void Edit(int id,PackageModel prdct)
        {
            PackageService.EditPackage(id,prdct);
        }
        [Route("api/Package/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            PackageService.DeletePackage(id);
        }
    }
}
