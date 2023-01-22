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

		public void AddWriter(Writer writer)
		{
			_writerDAL.Add(writer);
		}

		public void DeleteWriter(Writer writer)
		{
			_writerDAL.Delete(writer);
		}

		public List<Writer> GetAllWriters()
		{
			return _writerDAL.GetAll();
		}

		public Writer GetContacttById(int id)
		{
			return _writerDAL.GetById(id);
		}

		public void UpdateWriter(Writer writer)
		{
			_writerDAL.Update(writer);
		}
	}
}
