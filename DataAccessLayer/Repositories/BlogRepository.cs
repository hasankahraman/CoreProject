using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IGenericDAL<Blog>
    {
        Context context = new Context();
        public void Add(Blog blog)
        {
            context.Add(blog);
            context.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            context.Remove(blog);
            context.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            return context.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            return context.Blogs.Find(id);
        }

        public void Update(Blog blog)
        {
            context.Update(blog);
            context.SaveChanges();
        }
    }
}
