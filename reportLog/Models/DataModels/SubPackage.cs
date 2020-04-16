using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportLog.Models.DataModels
{
    public class SubPackage : BaseClass
    {
        public SubscriptionMode subMode { get; set; }
        public string Description { get; set; }
        public string AltCode { get; set; }
        public float Amount { get; set; }
    }
}