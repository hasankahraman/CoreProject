using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Writer
{
    
    public class VCWriterAboutDashboard : ViewComponent
    {
        WriterManager manager = new WriterManager(new EFWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = manager.GetWriterById(1);
            return View(values);
        }
    }
}
