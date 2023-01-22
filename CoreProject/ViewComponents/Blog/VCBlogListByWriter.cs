using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Blog
{
	public class VCBlogListByWriter : ViewComponent
	{
		BlogManager manager = new BlogManager(new EFBlogRepository());
		
		public IViewComponentResult Invoke()
		{
			var list = manager.GetAllByWriter(1);
			return View(list);

		}
	}
}
