using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportLog.Models.DataModels
{
    public class Company : BaseClass
    {
        public float CompanyID { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public DateTime SbDate { get; set; }
        public DateTime SbExpiry { get; set; }
        public SubscriptionMode subMode { get; set; }
        public int CurrentPackageType { get; set; }


    }
}