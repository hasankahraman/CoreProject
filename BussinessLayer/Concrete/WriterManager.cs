using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDAL _writerDAL;

		public WriterManager(IWriterDAL writerDAL)
		{
			_writerDAL = writerDAL;
		}

        public void Add(Writer t)
        {
            _writerDAL.Add(t);
        }
        public void Delete(Writer t)
        {
            _writerDAL.Delete(t);
        }
        public List<Writer> GetAll()
        {
            return _writerDAL.GetAll();
        }
        public Writer GetById(int id)
        {
            return _writerDAL.GetById(id);
        }
        public bool Login(Writer writer)
        {
			return _writerDAL.Login(writer);
        }
        public void Update(Writer t)
        {
            _writerDAL.Update(t);
        }
	}
}
