using CommunityService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunityService.Controllers
{
    public class SignUpForEventController : Controller
    {
        // GET: SignUpForEvent
        public ActionResult Index()
        {
            ViewBag.Page = "Sign Up for Event !!!!";
            return View();
        }

        //TODO:  redirect to thanks

        [HttpPost]
        public ViewResult SignUp(GuestResponse guestResponse)
        {
            // TODO: Email response to the party organizer
            // TODO: save in the database
            return View("Thanks", guestResponse);
        }


    }
}