using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.ViewComponents.Blog
{
    public class VCListLast3Blogs : ViewComponent
    {
        BlogManager manager = new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = manager.GetLast3Blogs();
            return View(values);
        }
    }
}
