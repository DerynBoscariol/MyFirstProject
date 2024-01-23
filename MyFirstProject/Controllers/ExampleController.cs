﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    public class ExampleController : ApiController
    {
        //GET request:  localhost:xx/api/example/name
        public string Get(string id)
        {
            string message = "Hello " + id;
            return message;
        }

        //GOAL
        //POST: localhost:xx/api/example
        public string Post()
        {
            return "Post Request";
        }
}
}
