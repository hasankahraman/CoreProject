using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
