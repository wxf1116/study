using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewStudent.Models;
using NewStudent.Dao;

namespace NewStudent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            StudentDao studentDao = new StudentDao();

            var Stuselect = studentDao.select();

            return View(Stuselect);
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}
