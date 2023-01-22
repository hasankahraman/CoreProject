using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager manager = new WriterManager(new EFWriterRepository());
		WriterValidator validator = new WriterValidator();
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			writer.Status = true;
			writer.About = "Kendisi bir yazardır.";
			writer.Image = "/coreblogtema/web/images/t3.jpg";
			
			ValidationResult validationResult = validator.Validate(writer);

			if (validationResult.IsValid)
			{
				manager.AddWriter(writer);
				return RedirectToAction("Index", "Blog");
			}else
			{
				foreach (var item in validationResult.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}

			
            
		}
	}
}
