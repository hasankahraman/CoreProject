using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Blog
{
	public class VCBlogListDashboard : ViewComponent
	{
		BlogManager manager = new BlogManager(new EFBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = manager.GetAllWithCategory();
			return View(values);
		}
	}
}
