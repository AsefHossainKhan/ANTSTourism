using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoucherRepo
    {
        static ANTSEntities context;
        static VoucherRepo()
        {
            context = new ANTSEntities();
        }

        public static List<Voucher> GetAllVouchers()
        {
            return context.Vouchers.ToList();
        }


        public static List<Voucher> GetSearchVouchers(string search)
        {
            var list = (from p in context.Vouchers
                        where p.voucher1.Contains(search)
                        select p).ToList();
            return list;
        }


        public static Voucher GetVoucher(int id)
        {
            return context.Vouchers.FirstOrDefault(e => e.voucherid == id);
        }

        public static Voucher AddVoucher(Voucher v)
        {
            context.Vouchers.Add(v);
            context.SaveChanges();
            return v;
        }

        public static Voucher EditVoucher(Voucher v)
        {
            var voucher = context.Vouchers.FirstOrDefault(e => e.voucherid == v.voucherid);
            context.Entry(voucher).CurrentValues.SetValues(v);
            context.SaveChanges();
            return voucher;
        }

        public static Voucher DeleteVoucher(int id)
        {
            var voucher = context.Vouchers.FirstOrDefault(e => e.voucherid == id);
            context.Vouchers.Remove(voucher);
            context.SaveChanges();
            return voucher;
        }
    }
}
