using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reportLog.Models.DataModels
{
    public class Rider: BaseClass
    {
        [Display(Name="Rider ID")]
        public string UserID { get; set; }
        public int CompanyID { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name= "Last Name")]
        public string LastName { get; set; }
        [Display(Name= "Other Name")]
        public string OtherName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DoB { get; set; }
        [Display(Name="Next of Kin")]
        public string NextOfKin { get; set; }
        [Display(Name= "Next of Kin Phone No.")]
        public string NextOfKinNumber { get; set; }
        public DateTime SbDate { get; set; }
        public DateTime SbExpiry { get; set; }

    }
}