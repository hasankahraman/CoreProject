using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.Controllers
{
	public class ContactController : Controller
	{
		ContactManager manager = new ContactManager(new EFContactRepository());

		[HttpGet]
		public IActionResult Index()
		{
			var list = manager.GetAll();
			return View(list);
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString());
			contact.Status = true;
			manager.Add(contact);
			return RedirectToAction("Index");
		}
	}
}
