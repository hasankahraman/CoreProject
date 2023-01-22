using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class NewsletterController : Controller
	{
		NewsletterManager manager = new NewsletterManager(new EFNewsletterRepository());

		[HttpGet]
		public PartialViewResult SubscribeNewsletter()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult SubscribeNewsletter(Newsletter newsletter)
		{
			newsletter.Status = true;
			manager.AddNewsletter(newsletter);
			return PartialView();
		}
	}
}
