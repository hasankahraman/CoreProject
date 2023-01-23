using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IWriterService
    {
        void AddWriter(Writer writer);
        void UpdateWriter(Writer writer);
        void DeleteWriter(Writer writer);
        List<Writer> GetAllWriters();
        Writer GetContacttById(int id);
        bool Login(Writer writer);
    }
}
