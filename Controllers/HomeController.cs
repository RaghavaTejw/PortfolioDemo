﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DownloadFile()
        {
            string path = "/Resume/RaghavaResume.pdf";
            string contentType = "application/pdf";
            string filename = "raghava.pdf";
            return File(path, contentType, filename);
        }
    }
}