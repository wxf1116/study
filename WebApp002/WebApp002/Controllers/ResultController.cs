using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApp002.Models;

namespace WebApp002.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult contentDemo()
        {
            return Content("Hello, World", "text/plain");
        }

        public ActionResult JavaScriptDemo()
        {
            return JavaScript("<script>function foo (){alert('foo');}</script>");
        }

        public ActionResult JsonDemo()
        {
            var m = new Menu1
            {
                Id = 3,
                Text = "sdjiwjijidfjsaid",
                price = 12.23,
                Category = "Main"
            };

            return Json(m, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RedirectDemo()
        {
            return Redirect("https://www.baidu.com");
        }

        public ActionResult RedirectRouteDemo()
        {
            return RedirectToRoute(new { controller = "Result" , action = "JsonDemo"});
        }

        public ActionResult FileDemo()
        {
            return File("~/Content/bootstrap.css", "css");
        }
    }
}