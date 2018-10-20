using CommunityService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunityService.Controllers
{
    public class EventController : Controller
    {
        public List<Event> EventStorage = new List<Event>
        {
            new Event{
                Category = "Animal Services",
                Description = "Help shelter",
                EventID = 1,
                ExtraInfo = "need people",
                Location ="Miami",
                Title ="Save a sato"
            },
            new Event{
                Category = "Environmental",
                Description = "Plant trees",
                EventID = 2,
                ExtraInfo = "need people",
                Location ="Miami",
                Title ="Need trees"
            }
        };

        // GET: Event
        public ActionResult Index()
        {
            return View(EventStorage);
        }

        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult CreateEvent(Event @event)
        {
            return View();
        }
    }
}