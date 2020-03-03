using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Web.Models
{
	public class Student
	{
		[Required(ErrorMessage ="İsminiz Giriniz")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Mail Giriniz")]
		[EmailAddress(ErrorMessage ="Yanlış formatta mail girdiniz")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Telefonu Giriniz")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Seçiniz")]
		public bool? WillAttend { get; set; }
	}
}
