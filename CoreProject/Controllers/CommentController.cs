using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject.Controllers
{
	public class CommentController : Controller
	{
		CommentManager manager = new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment comment)
		{
			comment.CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.Status = true;
			comment.BlogId = 2;
			manager.Add(comment);
			return PartialView();
		}
		public PartialViewResult PartialGetCommentsOfBlog(int id)
		{
			var list = manager.GetAll(id);
			return PartialView(list);
		}
	}
}
