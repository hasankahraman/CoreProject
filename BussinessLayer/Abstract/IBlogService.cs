using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        List<Blog> GetAllBlogs();
        Blog GetBlogById(int id);
        List<Blog> GetAllWithCategory();
    }
}
