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
        public Task<List<Contacts>> GetContacts();
        public Task<Contacts> GetContactById(int id);
        public Task<string> AddContact(Contacts contact);
        public Task<string> UpdateContact(Contacts contact);
        public Task<string> DeleteContact(Contacts contact);
    }
}
