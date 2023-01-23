using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
	public class LoginController : Controller
	{
		WriterManager manager = new WriterManager(new EFWriterRepository());
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            var result = manager.Login(writer);
            if (result)
            {
                var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, writer.Email)
                    };
                var userIdentity = new ClaimsIdentity(claims, "a");

                ClaimsPrincipal principle = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principle);

                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }

        }
    }
}


//var result = manager.Login(writer);

//if (result)
//{
//    HttpContext.Session.SetString("username", writer.Email);
//    return RedirectToAction("Index", "Writer");
//}
//else
//{
//    return View();
//}