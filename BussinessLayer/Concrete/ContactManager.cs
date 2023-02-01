﻿using BussinessLayer.Abstract;
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
        public void Add(Contact t)
        {
            _contactDAL.Add(t);
        }
        public void Delete(Contact t)
        {
            _contactDAL.Delete(t);
        }
        public List<Contact> GetAll()
        {
            return _contactDAL.GetAll();
        }
        public Contact GetById(int id)
        {
            return _contactDAL.GetById(id);
        }
        public void Update(Contact t)
        {
            _contactDAL.Update(t);
        }
	}
}
