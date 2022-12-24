using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers
{
    public class UniversityController : Controller
    {
        // GET: UniversityController
        public ActionResult Index()
        {
            UniversityContext u = UniversityContext.getInstance();
            List<Student> s = u.Student.ToList();
            return View(s);
        }

        // GET: UniversityController/Details/5
        public ActionResult Details(int id)
        {
            StudentRepository s = new StudentRepository();
            Debug.WriteLine(id);
            return View(s.getStudent(id));
        }

        // GET: UniversityController/Create
        public ActionResult Course (string id)
        {
            StudentRepository s = new StudentRepository();
            Debug.WriteLine(id);
            return View(s.getStudentsByCourse(id));
        }
        public ActionResult Courses(string id)
        {
            StudentRepository s = new StudentRepository();
            return View(s.getCourses());
        }
    }
}
