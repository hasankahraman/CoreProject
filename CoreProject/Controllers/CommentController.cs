﻿using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		public PartialViewResult PartialGetCommentsOfBlog()
		{
			return PartialView();
		}
	}
}
