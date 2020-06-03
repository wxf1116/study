using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp002.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public string Hello()
        {
            return "Hello, ASP.NET MVC.";
        }

        public string Greeting(string name)
        {
            return HttpUtility.HtmlEncode("Hello" + name);
        }

        public string Greeting2(string id)
        {
            return HttpUtility.HtmlEncode("Hello," + id);
        }

        public int Add (int x, int y)
        {
            return x + y;
        }

        
    }
}
