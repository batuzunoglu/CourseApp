using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers{

        public class CourseController:Controller
        {
            public IActionResult Index(){
                return View();
            }

            public IActionResult Apply()
            {
              return View();
            }

            public IActionResult Details(){
                var course = new Course();
                course.Name = "Core Mvc Kursu";
                course.description = "güzel bir kurs";
                course.isPublished = true;
                
                return View(course);
            }

             public IActionResult List(){
                return View();
            }


        }
}