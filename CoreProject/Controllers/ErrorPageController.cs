using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Index(int code)
		{
			return View();
		}
	}
}
