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

        public void Add(Comment t)
        {
            _commentDAL.Add(t);
        }

        public void Delete(Comment t)
        {
            _commentDAL.Delete(t);
        }
        public List<Comment> GetAll(int id)
        {
            return _commentDAL.GetAll(x => x.BlogId == id);
        }

        public List<Comment> GetAll()
        {
            return _commentDAL.GetAll();
        }

        public Comment GetById(int id)
        {
            return _commentDAL.GetById(id);
        }
        public void Update(Comment t)
        {
            _commentDAL.Update(t);
        }
	}
}
