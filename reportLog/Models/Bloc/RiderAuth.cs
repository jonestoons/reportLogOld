using reportLog.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading;
using System.Security.Principal;

namespace reportLog.Models.Bloc
{
    public class RiderAuthAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if(actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
                string[] loginCred = decodedAuthenticationToken.Split(':');
                string username = loginCred[0];
                string password = loginCred[1];

                if (RiderAuth.Login(username, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
    public class RiderAuth
    {
        public static bool Login(string userID, string password)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Rider rider = db.Riders.Where(x => x.UserID == userID).FirstOrDefault();
            if (rider != null)
            {
                bool passwordCheck = PasswordHandler.Validate(password: password, passwordHash: rider.Password);

                if (passwordCheck == true)
                {

                }
            }

            return;

        }

    }
}