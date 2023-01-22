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

		public void AddAbout(About about)
		{
			_aboutDAL.Add(about);
		}

		public void DeleteAbout(About about)
		{
			_aboutDAL.Delete(about);
		}

		public About GetAboutById(int id)
		{
			return _aboutDAL.GetById(id);
		}

		public List<About> GetAllAbouts()
		{
			return _aboutDAL.GetAll();
		}

		public void UpdateAbout(About about)
		{
			_aboutDAL.Update(about);
		}
	}
}
