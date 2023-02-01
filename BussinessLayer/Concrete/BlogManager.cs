using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDAL _blogDAL;

		public BlogManager(IBlogDAL blogDAL)
		{
			_blogDAL = blogDAL;
		}
        public List<Blog> GetAll()
        {
            return _blogDAL.GetAll();
        }
        public List<Blog> GetAll(int id)
		{
			return _blogDAL.GetAll(x=> x.Id == id);
		}
		public List<Blog> GetAllWithCategory()
		{
			return _blogDAL.GetAllWithCategory();
		}
		public List<Blog> GetAllByWriter(int id)
		{
			return _blogDAL.GetAll(x => x.WriterId == id);
		}
		public List<Blog> GetLast3Blogs()
		{
			return _blogDAL.GetAll().Take(3).ToList();
		}
        public void Add(Blog t)
        {
            _blogDAL.Add(t);
        }
        public void Update(Blog t)
        {
			_blogDAL.Update(t);
        }
        public void Delete(Blog t)
        {
			_blogDAL.Delete(t);
        }
        public Blog GetById(int id)
        {
            return _blogDAL.GetById(id);
        }
		public List<Blog> GetAllWithCategoryByWriter(int writerId)
		{
			return _blogDAL.GetAllWithCategoryByWriter(writerId);
		}
	}
}
