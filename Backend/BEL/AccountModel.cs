using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AccountModel
    {
        public int accountid { get; set; }
        public double balance { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public string paytype { get; set; }
        public string transferdetails { get; set; }
        public string status { get; set; }
        public System.DateTime createdat { get; set; }
        public int userid { get; set; }
    }
}
