using reportLog.Models;
using reportLog.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reportLog.Controllers
{
    public class NewsLetterController : Controller
    {
        
        // GET: NewsLetter
        [HttpPost]
        public JsonResult getEmail(string email)
        {
            if (email == "" || email.Contains("@"))
            {
                ApplicationDbContext db = new ApplicationDbContext();
                EmailListings em = new EmailListings();
                em.Email = email;

                db.EmailLists.Add(em);
                db.SaveChanges();
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);

            }

        }
    }
}