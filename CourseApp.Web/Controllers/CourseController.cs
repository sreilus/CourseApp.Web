using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Web.Controllers
{
	public class CourseController : Controller
	{
		//couse/index
		public ViewResult Index()
		{
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour > 12 ? "Good Afternoon" : "Good night";
			return View("MyView");
		}

		//couse/list
		public ViewResult List()
		{
			var liste = Repository.Students.Where(x => x.WillAttend == true);
			return View(liste);
		}

		[HttpGet]
		//couse/apply
		public ViewResult Apply()
		{
			return View();
		}

		[HttpPost]
		public ViewResult Apply(Student student)
		{
			if (ModelState.IsValid)
			{
				Repository.AddStudent(student);
				return View("Thanks", student);
			}
			else
			{
				return View();
			}
		}
	}
}