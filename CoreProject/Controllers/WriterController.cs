﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
	}
}
