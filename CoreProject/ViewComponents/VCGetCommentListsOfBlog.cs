using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents
{
	public class VCGetCommentListsOfBlog : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
