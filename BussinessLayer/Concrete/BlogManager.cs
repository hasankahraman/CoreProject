﻿using BussinessLayer.Abstract;
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

		public void AddBlog(Blog blog)
		{
			_blogDAL.Add(blog);
		}

		public void DeleteBlog(Blog blog)
		{
			_blogDAL.Delete(blog);
		}

		public List<Blog> GetAllBlogs()
		{
			return _blogDAL.GetAll();
		}

		public List<Blog> GetAllBlogs(int id)
		{
			return _blogDAL.GetAll(x=> x.Id == id);
		}

		public List<Blog> GetAllWithCategory()
		{
			return _blogDAL.GetAllWithCategory();
		}

		public Blog GetBlogById(int id)
		{
			return _blogDAL.GetById(id);
		}

		public void UpdateBlog(Blog blog)
		{
			_blogDAL.Update(blog);
		}
	}
}
