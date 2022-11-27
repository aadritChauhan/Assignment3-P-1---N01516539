 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolDb.Models;

namespace SchoolDb.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teach er
        public ActionResult Index()
        {
            return View();
        }

        //GET : /Teachers/List
        public ActionResult List(string SearchKey= null)
        {
            TeacherDataController controller = new TeacherDataController();
            IEnumerable<Teacher> Teachers = controller.ListTeachers(SearchKey);
            return View(Teachers);
        }

        //GET : /Teacher/Show/{id}
        public ActionResult Show(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher NewTeacher = controller.FindTeacher(id);


            return View(NewTeacher);
        }
    }
}
