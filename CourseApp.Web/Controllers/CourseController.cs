using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Web.Controllers
{
    public class CourseController : Controller
    {
		//couse/index
        public ViewResult Index()
        {
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour > 12? "Good Afternoon" : "Good night";
            return View("MyView");
        }

		//couse/list
		public ViewResult List()
		{
			return View();
		}

		//couse/apply
		public ViewResult Apply()
		{
			return View();
		}
	}
}