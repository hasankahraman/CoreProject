using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void AddCategory(Category category)
        {
            _categoryDAL.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
