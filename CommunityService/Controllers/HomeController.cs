using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityService.Models;

namespace CommunityService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Greeting = "Hello, here are events where you can help";
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

        public ViewResult ListofEvents()
        {
            return View();
        }

        public ViewResult ListofOrganizations()
        {
            return View();
        }

        public ActionResult SignupNewsLetter()
        {
            return View();
        }
    }
}