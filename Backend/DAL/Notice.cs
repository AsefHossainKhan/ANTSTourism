//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notice
    {
        public int noticeid { get; set; }
        public int userid { get; set; }
        public string usertype { get; set; }
        public string notice1 { get; set; }
        public System.DateTime createdat { get; set; }
        public string status { get; set; }
    
        public virtual User User { get; set; }
    }
}
