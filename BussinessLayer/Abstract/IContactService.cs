using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
        List<Contact> GetAllContacts();
        Contact GetContacttById(int id);
    }
}
