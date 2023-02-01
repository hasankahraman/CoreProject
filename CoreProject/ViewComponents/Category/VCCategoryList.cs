using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Category
{
	public class VCCategoryList : ViewComponent
	{
		CategoryManager manager = new CategoryManager(new EFCategoryRepository());
		public IViewComponentResult Invoke(int id)
		{
			var categoryList = manager.GetAll();
			return View(categoryList);
		}
	}
}
