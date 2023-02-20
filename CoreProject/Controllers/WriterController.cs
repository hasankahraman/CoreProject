using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using CoreProject.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreProject.Controllers
{
	public class WriterController : Controller
	{
		WriterManager manager = new WriterManager(new EFWriterRepository());
		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult WriterProfile()
		{
			return View();
		}
        [AllowAnonymous]
        public PartialViewResult PartialWriterNavbar()
		{
			return PartialView();
		}
        [AllowAnonymous]
        public PartialViewResult PartialWriterFooter()
        {
            return PartialView();
        }
        [AllowAnonymous]
		[HttpGet]
        public IActionResult WriterProfileUpdate()
        {
			var values = manager.GetById(1);
            return View(values);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterProfileUpdate(Writer writer)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult result = validator.Validate(writer);
            writer.Status = true;
            writer.Image = "/coreblogtema/web/images/t1.jpg";

            if (result.IsValid)
            {
                manager.Update(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer writer = new Writer();
            if (p.Image != null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                writer.Image = newImageName;
            }
            writer.Email = p.Email;
            writer.Name = p.Name;
            writer.Password = p.Password;
            writer.Status = p.Status;
            writer.About = p.About;

            manager.Add(writer);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
