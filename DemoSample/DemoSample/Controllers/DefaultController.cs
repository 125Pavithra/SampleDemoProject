using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoSample.Controllers
{
    public class DefaultController : ApiController
    {
        public string Post()
        {
            return "HEllo";
        }
    }
}
