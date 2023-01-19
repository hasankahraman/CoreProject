using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContactDAL
    {
        List<Contact> GetAll();
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
        Contact GetById(int id);
    }
}
