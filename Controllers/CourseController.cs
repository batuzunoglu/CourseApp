using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    // localhost:5000/course
    public class CourseController : Controller
    {
        // action method
        // localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            var kurs = new Course{Id = 1, Name = "komple uygulamalı geliştirici kursu"};
            ViewData["course"] = kurs;
            return View();
        }

        // localhost:5000/course/apply
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        // localhost:5000/course/apply method:POST
        // Name=value&Email=value&Phone=value&Confirm=value
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            if (ModelState.IsValid){
            Repository.AddStudent(student);
            return View("Thanks", student);
            }else{
                return View(student);
            }
        }

        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }

        // localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
          var students = Repository.Students.Where(i=>i.Confirm==true);

            return View(students);
        }
    }
}