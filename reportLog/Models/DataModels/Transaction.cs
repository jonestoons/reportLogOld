using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportLog.Models.DataModels
{
    public class Transaction : BaseClass
    {
        public double TID { get; set; }
        public int CompanyID { get; set; }
        public int RiderID { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public PaymentType PayType { get; set; }
        public int CustomerID { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}