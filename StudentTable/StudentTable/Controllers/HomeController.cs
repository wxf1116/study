using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentTable.Models;
using stutab = StudentTable.Student;

namespace StudentTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var stu = new stutab.Student();
            var smod = new StudentModel();
            var stuselcet = stu.select(smod);
            return View(stuselcet);
        }

        public ActionResult Add()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Add(StudentModel stumod)
        {

            var add = new stutab.Student();
            add.Add(stumod);
            return Redirect(Url.Action("Index", "Home"));

        }

        public ActionResult Delete()
        {
            
            return View();

        }

        [HttpPost]
        public ActionResult Delete(StudentModel stumod)
        {
            var delete = new stutab.Student();
            delete.Delete(stumod);
            return Redirect(Url.Action("Index", "Home"));
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(StudentModel stumod)
        {
            var upda = new stutab.Student();
            upda.Update(stumod);
            return Redirect(Url.Action("Index", "Home"));
        }

    }
}
