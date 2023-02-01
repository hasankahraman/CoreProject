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

        public void Add(Newsletter t)
        {
            _newsletterDAL.Add(t);
        }
        public void Delete(Newsletter t)
        {
            _newsletterDAL.Delete(t);

        }
        public List<Newsletter> GetAll()
        {
            return _newsletterDAL.GetAll();
        }

        public Newsletter GetById(int id)
        {
            return _newsletterDAL.GetById(id);
        }
        public void Update(Newsletter t)
        {
            _newsletterDAL.Update(t);
        }
	}
}
