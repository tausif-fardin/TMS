//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertiser
    {
        public int advertiserid { get; set; }
        public string advertisername { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string type { get; set; }
        public double adbudget { get; set; }
        public Nullable<int> adminid { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual User User { get; set; }
    }
}
