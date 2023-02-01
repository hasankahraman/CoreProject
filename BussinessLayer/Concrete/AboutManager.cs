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
	public class AboutManager : IAboutService
	{
		IAboutDAL _aboutDAL;

		public AboutManager(IAboutDAL aboutDAL)
		{
			_aboutDAL = aboutDAL;
		}
        public void Add(About t)
        {
            _aboutDAL.Add(t);
        }
        public void Delete(About t)
        {
            _aboutDAL.Delete(t);
        }
		public About GetById(int id)
		{
			return _aboutDAL.GetById(id);
		}
        public List<About> GetAll()
        {
            return _aboutDAL.GetAll();
        }
        public void Update(About t)
        {
            _aboutDAL.Update(t);
        }
	}
}
