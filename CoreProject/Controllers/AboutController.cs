using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class AboutController : Controller
	{
		AboutManager manager = new AboutManager(new EFAboutRepository());
		public IActionResult Index()
		{
			var list = manager.GetAll();
			return View(list);
		}

		public PartialViewResult SocialMedia()
		{
			return PartialView();
		}
	}
}
