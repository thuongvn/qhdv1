﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;using System.Web.Routing;

namespace QUANGHANHCORE.Controllers.DK
{
    public class DKController : Controller
    {
        [Route("phong-dieu-khien")]
        public ActionResult Index()
        {
            return View("/Views/DK/Index.cshtml");
        }
    }
}