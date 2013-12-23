using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotNET_demo.Models;

namespace dotNET_demo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ViewBag.news = db.News.ToList().Take(3);
            ViewBag.products = db.Products.ToList().Take(3);
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

        public ActionResult Privacy()
        {
            ViewBag.Message = "Privacy page";

            return View();
        }
    }
}