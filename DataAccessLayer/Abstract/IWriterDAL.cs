using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IWriterDAL
    {
        List<Writer> GetAll();
        void Add(Writer writer);
        void Update(Writer writer);
        void Delete(Writer writer);
        Writer GetById(int id);
    }
}
