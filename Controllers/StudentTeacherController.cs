using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using MVCModelView.Models;


namespace MVCModelView.Controllers
{
    public class StudentTeacherController : Controller
    {
        // GET: StudentTeacher
        public ActionResult Details()
        {
            dynamic container = new ExpandoObject();
            StudentDAL obj = new StudentDAL();
            container.st = obj.GetStudents();

            TeacherDAL obj1 = new TeacherDAL();
            container.tea = obj1.GetTeachers();
            return View(container);
        }
    }
}