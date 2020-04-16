using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportLog.Models.DataModels
{
    public class Booking : BaseClass
    {
        public double BookingID { get; set; }
        public int RiderID { get; set; }
        public int CustomerID { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public bool ConfirmationStatus { get; set; }
        public DateTime ConfirmationTime { get; set; }
    }
}