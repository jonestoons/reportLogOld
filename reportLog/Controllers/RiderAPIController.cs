using reportLog.Models.Bloc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace reportLog.Controllers
{
    public class RiderAPIController : ApiController
    {
        //[RiderAuthAttribute]
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
