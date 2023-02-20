using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.Controllers
{
	public class DashboardController : Controller
	{
		BlogManager blogManager = new BlogManager(new EFBlogRepository());
		CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());

		[AllowAnonymous]
		public IActionResult Index()
		{
			ViewBag.blogCount = blogManager.GetAll().Count;
            ViewBag.writerBlogCount = blogManager.GetAll().Where(x => x.WriterId == 1).Count();
            ViewBag.categoryCount = categoryManager.GetAll().Count;
            return View();
		}
	}
}
