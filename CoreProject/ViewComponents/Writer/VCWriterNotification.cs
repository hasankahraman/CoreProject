using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Writer
{
    public class VCWriterNotification : ViewComponent
    {
        WriterManager manager = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
