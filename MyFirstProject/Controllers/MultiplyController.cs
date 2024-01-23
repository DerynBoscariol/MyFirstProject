using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    public class MultiplyController : ApiController
    {
        //GET localhostxx/api/Multiply/5 --- 15

        public int Get(int id)
        {
            int product = id * 3;
            return product;
        }
    }
}
