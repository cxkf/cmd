using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "修改此模板以快速启动你的 ASP.NET MVC 应用程序。";
            var siteInfo = new WebsiteInfo("demo", "RIGHT");

            ViewBag.siteInfo = siteInfo;


           // ViewData["siteInfo"] = siteInfo;

          // if (new Random().Next(2) == 0)
              return View ("~/Views/Home/View1.cshtml");
           // else
             //   return View(siteInfo);


           // return View("~/Views/Home/View2.cshtml");


           return View("~/Views/Home/View3.cshtml");

        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
