using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

namespace CourseApp.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			var course = new Course();
			course.Id = 1;
			course.Name = "Asp.Net Core 2 Kursu";
			return View(course);
        }
    }
}