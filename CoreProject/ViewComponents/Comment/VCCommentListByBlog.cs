using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Comment
{
	public class VCCommentListByBlog: ViewComponent
	{
		CommentManager manager = new CommentManager(new EFCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var commentList = manager.GetAllComments(id);
			return View(commentList);
		}
	}
}
