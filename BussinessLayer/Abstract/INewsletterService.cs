using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
	public interface INewsletterService
	{
		void AddNewsletter(Newsletter newsletter);
		void UpdateNewsletter(Newsletter newsletter);
		void DeleteNewsletter(Newsletter newsletter);
		List<Newsletter> GetAllNewsletters();
		Newsletter GetNewsletterById(int id);
	}
}
