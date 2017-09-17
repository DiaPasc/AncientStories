using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AncientStories.Controllers
{
    public class AncientStoriesController : Controller
    {
        // GET: AncientStories
        public ActionResult Index()
        {
            return View();
        }
    }
}