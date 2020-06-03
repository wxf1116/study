using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApp002.Models;
using abc = WebApp002.Dao;

namespace WebApp002.Controllers
{
    public class SubmitDataController : Controller
    {
        // GET: SubmitData
        public ActionResult PassingData()
        {
            ViewBag.MyData = "Hello";
            return View();
        }

        public ActionResult PassingAModel()
        {
            var menus = new List<Menu1>
            {
                new Menu1{Id = 1, Text = "SmKuS", price = 6.9, Category  = "Main" },
                new Menu1 {Id = 2, Text = "EmTuG", price = 6.9, Category  = "Vegetarian"},
                new Menu1 {Id = 3, Text = "TBmSuK", price = 6.9, Category  = "Main"}
            };
            return View(menus);
        }

        public ActionResult CreateMenu()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateMenu(StudentModels st)
        {
            var add = new abc.StudentDao();
            add.Add(st);
            //var m = new Menu1 { Id = id, Text = text, price = price };
            //ViewBag.Info = string.Format(
            //    "menu created:{0}, price = {1}, category: {2}", m.Text, m.price, m.Category
            //    );
            return View("PassingData");
        }
    }
}