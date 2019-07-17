using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
public class HomeController:Controller{

    
    
    public IActionResult Index(){
    int saat = DateTime.Now.Hour;
    ViewBag.Greeting = saat < 12 ? "günaydın" : "iyi günler";
    ViewBag.UserName = "Batuhan";
    return View();
    }
    public IActionResult About(){
    return View();
    }
}
}