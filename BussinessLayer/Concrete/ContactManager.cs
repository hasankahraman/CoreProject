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
	public class ContactManager : IContactService
	{
		IContactDAL _contactDAL;

		public ContactManager(IContactDAL contactDAL)
		{
			_contactDAL = contactDAL;
		}

		public void AddContact(Contact contact)
		{
			_contactDAL.Add(contact);
		}

		public void DeleteContact(Contact contact)
		{
			_contactDAL.Delete(contact);
		}

		public List<Contact> GetAllContacts()
		{
			return _contactDAL.GetAll();
		}

		public Contact GetContacttById(int id)
		{
			return _contactDAL.GetById(id);
		}

		public void UpdateContact(Contact contact)
		{
			_contactDAL.Update(contact);
		}
	}
}
