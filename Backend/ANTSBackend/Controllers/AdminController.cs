using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ANTSBackend.Controllers
{
    public class AdminController : ApiController
    {
        //USERS
        [Route("api/users/all")]
        [HttpGet]
        public List<UserModel> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }

        [Route("api/users/search/{search}")]
        [HttpGet]
        public List<UserModel> GetSearchUsers(string search)
        {
            return UserService.GetSearchUsers(search);
        }

        [Route("api/users/{id}")]
        [HttpGet]
        public UserModel GetUser(int id)
        {
            return UserService.GetUser(id);
        }

        [Route("api/users/add")]
        [HttpPost]
        public UserModel AddUser(UserModel user)
        {
            user.usertype = "Manager";
            user.createdat = DateTime.Now;
            return UserService.AddUser(user);
        }

        [Route("api/users/edit")]
        [HttpPut]
        public UserModel EditUser(UserModel user)
        {
            return UserService.EditUser(user);
        }

        [Route("api/users/delete/{id}")]
        [HttpDelete]
        public UserModel DeleteUser(int id)
        {
            return UserService.DeleteUser(id);
        }

        //NOTICES
        [Route("api/notices/all")]
        [HttpGet]
        public List<NoticeModel> GetAllNotices()
        {
            return NoticeService.GetAllNotices();
        }

        [Route("api/notices/{id}")]
        [HttpGet]
        public NoticeModel GetNotice(int id)
        {
            return NoticeService.GetNotice(id);
        }

        [Route("api/notices/add")]
        [HttpPost]
        public NoticeModel AddNotice(NoticeModel notice)
        {
            return NoticeService.AddNotice(notice);
        }

        [Route("api/notices/edit/{id}")]
        [HttpPost]
        public NoticeModel EditNotice(NoticeModel notice)
        {
            return NoticeService.EditNotice(notice);
        }

        [Route("api/notices/delete/{id}")]
        [HttpGet]
        public NoticeModel DeleteNotice(int id)
        {
            return NoticeService.DeleteNotice(id);
        }

        //RATINGS
        [Route("api/ratings/all")]
        [HttpGet]
        public List<RatingModel> GetAllRatings()
        {
            return RatingService.GetAllRatings();
        }

        [Route("api/ratings/{id}")]
        [HttpGet]
        public RatingModel GetRating(int id)
        {
            return RatingService.GetRating(id);
        }

        [Route("api/ratings/add")]
        [HttpPost]
        public RatingModel AddRating(RatingModel rating)
        {
            return RatingService.AddRating(rating);
        }

        [Route("api/ratings/edit/{id}")]
        [HttpPost]
        public RatingModel EditRating(RatingModel rating)
        {
            return RatingService.EditRating(rating);
        }

        [Route("api/ratings/delete/{id}")]
        [HttpGet]
        public RatingModel DeleteRating(int id)
        {
            return RatingService.DeleteRating(id);
        }

        //VOUCHERS
        [Route("api/vouchers/all")]
        [HttpGet]
        public List<VoucherModel> GetAllVouchers()
        {
            return VoucherService.GetAllVouchers();
        }

        [Route("api/vouchers/{id}")]
        [HttpGet]
        public VoucherModel GetVoucher(int id)
        {
            return VoucherService.GetVoucher(id);
        }

        [Route("api/vouchers/add")]
        [HttpPost]
        public VoucherModel AddVoucher(VoucherModel voucher)
        {
            return VoucherService.AddVoucher(voucher);
        }

        [Route("api/vouchers/edit/{id}")]
        [HttpPost]
        public VoucherModel EditVoucher(VoucherModel voucher)
        {
            return VoucherService.EditVoucher(voucher);
        }

        [Route("api/vouchers/delete/{id}")]
        [HttpGet]
        public VoucherModel DeleteVoucher(int id)
        {
            return VoucherService.DeleteVoucher(id);
        }
    }
}
