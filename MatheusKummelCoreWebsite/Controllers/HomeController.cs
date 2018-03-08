using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatheusKummelCoreWebsite.Models;

namespace MatheusKummelCoreWebsite.Controllers
{
    public class HomeController : Controller
    {
        //[Localization("en")]
        public ActionResult Index()
        {
            return View();
        }

        //[Localization("en")]
        public ActionResult About()
        {
            ViewBag.Message = "About Matheus";

            return View();
        }
    }
}