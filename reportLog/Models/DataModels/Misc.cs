using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportLog.Models.DataModels
{
   public enum SubscriptionMode
    {
        Rider,
        Full
    }

    public enum PaymentType
    {
        Cash,
        POS,
        BankTransfer,
        Other
    }
}