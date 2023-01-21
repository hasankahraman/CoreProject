using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var categoryList = manager.GetAllCategories();
            return View(categoryList);
        }
    }
}
