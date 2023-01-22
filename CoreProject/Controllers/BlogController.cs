using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager manager = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var list = manager.GetAllByCategory();
            return View(list);
        }
		public IActionResult BlogDetails(int id)
		{
			var blog = manager.GetBlogById(id);
            ViewBag.BlogId = id;
			return View(blog);
		}
	}
}
