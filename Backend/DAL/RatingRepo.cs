using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RatingRepo
    {
        static ANTSEntities context;
        static RatingRepo()
        {
            context = new ANTSEntities();
        }

        public static List<Rating> GetAllRatings()
        {
            return context.Ratings.Where(e => e.complain != null).ToList();
        }

        public static Rating GetRating(int id)
        {
            return context.Ratings.FirstOrDefault(e => e.ratingid == id);
        }

        public static Rating AddRating(Rating r)
        {
            context.Ratings.Add(r);
            context.SaveChanges();
            return r;
        }

        public static Rating EditRating(Rating r)
        {
            var rating = context.Ratings.FirstOrDefault(e => e.ratingid == r.ratingid);
            context.Entry(rating).CurrentValues.SetValues(r);
            context.SaveChanges();
            return rating;
        }

        public static Rating DeleteRating(int id)
        {
            var rating = context.Ratings.FirstOrDefault(e => e.ratingid == id);
            context.Ratings.Remove(rating);
            context.SaveChanges();
            return rating;
        }
    }
}
