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
	public class NewsletterManager : INewsletterService
	{
		INewsletterDAL _newsletterDAL;

		public NewsletterManager(INewsletterDAL newsletterDAL)
		{
			_newsletterDAL = newsletterDAL;
		}

		public void AddNewsletter(Newsletter newsletter)
		{
			_newsletterDAL.Add(newsletter);
		}

		public void DeleteNewsletter(Newsletter newsletter)
		{
			_newsletterDAL.Delete(newsletter);
		}

		public List<Newsletter> GetAllNewsletters()
		{
			return _newsletterDAL.GetAll();
		}

		public Newsletter GetNewsletterById(int id)
		{
			return _newsletterDAL.GetById(id);
		}

		public void UpdateNewsletter(Newsletter newsletter)
		{
			_newsletterDAL.Update(newsletter);
		}
	}
}
