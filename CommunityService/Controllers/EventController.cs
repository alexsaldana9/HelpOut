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
        public static List<Event> EventStorage = new List<Event>
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
            var selectedEvent = EventStorage.Find(e => e.EventID == id);

            if (selectedEvent == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(selectedEvent);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Event @event)
        {
            //TODO: save the event
            // parts.Add(new Part() {PartName="crank arm", PartId=1234});
            //EventStorage.Add(new Event()
            //{
            //    Category = @event.Category,
            //    Description = @event.Description,
            //    EventID = @event.EventID,
            //    ExtraInfo = @event.ExtraInfo,
            //    Location = @event.Location,
            //    Title = @event.Title
            //});
            @event.EventID = EventStorage.Count + 1;
            EventStorage.Add(@event);

            return RedirectToAction("Details", new { id = @event.EventID });
        }
    }
}