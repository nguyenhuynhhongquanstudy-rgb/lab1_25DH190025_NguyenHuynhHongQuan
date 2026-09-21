using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1_25DH190025_NguyenHuynhHongQuan.Controllers
{
    public class HomeController : Controller

    {
        public ActionResult BT1()
        {
            return View();
        }

        public ActionResult BT2()
        {
            return View();
        }

        public ActionResult BT3()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}