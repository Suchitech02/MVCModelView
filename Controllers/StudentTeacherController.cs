using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelView.Controllers
{
    public class StudentTeacherController : Controller
    {
        // GET: StudentTeacher
        public ActionResult Index()
        {
            return View();
        }
    }
}