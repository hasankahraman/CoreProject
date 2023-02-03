using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        
        BlogManager manager = new BlogManager(new EFBlogRepository());
		CategoryManager catManager = new CategoryManager(new EFCategoryRepository());
		public IActionResult Index()
        {
            var list = manager.GetAllWithCategory();
            return View(list);
        }
		public IActionResult BlogDetails(int id)
		{
			var blog = manager.GetById(id);
            ViewBag.BlogId = id;
			return View(blog);
		}
        public IActionResult BlogListByWriter()
        {
            int writerId = 1;
            var writerBlogs = manager.GetAllWithCategoryByWriter(writerId);
            return View(writerBlogs);
        }
        [HttpGet]
        public IActionResult CreateNewBlog()
        {
            List<SelectListItem> categories = (from x in catManager.GetAll()
                                               select new SelectListItem
                                               { Text = x.Name,
                                               Value = x.Id.ToString()
                                               }).ToList();
            ViewBag.SelectListValues = categories;
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewBlog(Blog blog)
        {
            BlogValidator validator = new BlogValidator();
            ValidationResult validationResult = validator.Validate(blog);

            if (validationResult.IsValid)
            {
                blog.CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.Status = true;
                blog.WriterId = 1;

                manager.Add(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogToDelete = manager.GetById(id);
            manager.Delete(blogToDelete);
            return RedirectToAction("BlogListByWriter");

        }
        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {

            List<SelectListItem> categories = (from x in catManager.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();
            ViewBag.SelectListValues = categories;

            var blogToUpdate = manager.GetById(id);
            return View(blogToUpdate);
        }
        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            BlogValidator validator = new BlogValidator();
            ValidationResult validationResult = validator.Validate(blog);

            if (validationResult.IsValid)
            {
				blog.CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString());
				blog.Status = true;
				blog.WriterId = 1;
				manager.Update(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
