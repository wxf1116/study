using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp002.Models;

namespace WebApp002.Controllers
{
    public class ViewsDemoController : Controller
    {
        // GET: ViewDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UseAPartialViewl()
        {
            return View(new EventsAndMenus());
        }
    }
}