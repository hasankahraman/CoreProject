using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EFBlogRepository : GenericRepository<Blog>, IBlogDAL
	{
		public List<Blog> GetAllWithCategory()
		{
			using (var context = new Context())
			{
				return context.Blogs.Include(x => x.Category).ToList();
			}
			
		}

		public List<Blog> GetAllWithCategoryByWriter(int writerId)
		{
			using (var context = new Context())
			{
				return context.Blogs.Include(x => x.Category)
					.Where(y=> y.WriterId == writerId)
					.ToList();
			}
		}
	}
}
