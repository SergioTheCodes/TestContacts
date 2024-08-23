using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IContactService
    {
        //public Task Login();
        public Task<List<Contact>> GetContacts();
        public Task<string> AddContact(Contact contact);
        public Task<string> UpdateContact(Contact contact);
        public Task<string> DeleteContact(Contact contact);
    }
}
