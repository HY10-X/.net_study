﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorld.Controllers
{
    public class HoController : Controller
    {
        //
        // GET: /Ho/

        public ActionResult Index()
        {
            return View();
        }

    }
}
