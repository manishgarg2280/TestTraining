using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSitecore.web.Models;

namespace TestSitecore.web.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            EventRenderingViewModel model = new EventRenderingViewModel();
            model.item = Sitecore.Context.Item;

            //model.EventName = Sitecore.Context.Item.Fields["EventName"].Value;
            //model.EventDate = Sitecore.Context.Item.Fields["EventDate"].Value;
            //model.EventDescription = Sitecore.Context.Item.Fields["EventDescription"].Value;
            return View(model);
        }
    }
}