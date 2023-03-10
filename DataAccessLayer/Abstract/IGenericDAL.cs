using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T:class
    {
        List<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
