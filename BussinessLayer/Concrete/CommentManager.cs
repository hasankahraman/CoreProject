using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDAL _commentDAL;

		public CommentManager(ICommentDAL commentDAL)
		{
			_commentDAL = commentDAL;
		}

		public void AddComment(Comment comment)
		{
			_commentDAL.Add(comment);
		}

		public void DeleteComment(Comment comment)
		{
			_commentDAL.Delete(comment);
		}

		public List<Comment> GetAllComments(int id)
		{
			return _commentDAL.GetAll(x=> x.BlogId==id);
		}

		public List<Comment> GetAllComments()
		{
			return _commentDAL.GetAll();
		}

		public Comment GetCommentById(int id)
		{
			return _commentDAL.GetById(id);
		}

		public void UpdateComment(Comment comment)
		{
			_commentDAL.Update(comment);
		}
	}
}
