using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Service;
using Infrastructure.Data;
using System.Linq;
//using Infrastructure.Data;

namespace ContactApi.Service
{
    public class ContactService : BaseService, IContactService

    {
        //private readonly IContactRepository _contactRepository;
        public ContactService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<string> AddContact(Contacts contact)
        {
            var repository = UnitOfWork.AsyncRepository<Infrastructure.Data.Contact>();

            var obj = new Infrastructure.Data.Contact
            {
                Name = contact.Name,
                Phonenumber = contact.PhoneNumber
            };

            try
            {
                await repository.AddAsync(obj);
                await UnitOfWork.SaveChangesAsync();
                return "Contact Added SuccessFully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<string> UpdateContact(Contacts contact)
        {
            var repository = UnitOfWork.AsyncRepository<Infrastructure.Data.Contact>();
            var obj = new Infrastructure.Data.Contact
            {
                Name = contact.Name,
                Phonenumber = contact.PhoneNumber
            };
            try
            {
                await repository.UpdateAsync(obj);
                await UnitOfWork.SaveChangesAsync();
                return "Contact Updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<List<Contacts>> GetContacts()
        {
            var repository = UnitOfWork.AsyncRepository<Infrastructure.Data.Contact>();
            try
            {
                var contactList = await repository.ListAsync(_ => _.Id > 0);
                var obj = contactList.Select(contact => new Contacts
                {
                    Id =  contact.Id,
                    Name = contact.Name,
                    PhoneNumber = contact.Phonenumber
                }).ToList();
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Contacts> GetContactById(int id)
        {
            var repository = UnitOfWork.AsyncRepository<Infrastructure.Data.Contact>();
            try
            {
                var contactList = await repository.ListAsync(_ => _.Id > 0);
                var obj = contactList.Where(contact => contact.Id == id).Select(x => new Contacts
                {
                    Id = x.Id,
                    Name = x.Name,
                    PhoneNumber = x.Phonenumber
                }).FirstOrDefault();
                return obj;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<string> DeleteContact(Contacts contact)
        {
            var repository = UnitOfWork.AsyncRepository<Infrastructure.Data.Contact>();
            var obj = new Infrastructure.Data.Contact
            {
                Id= contact.Id,
                Name = contact.Name,
                Phonenumber = contact.PhoneNumber
            };
            try
            {
                await repository.DeleteAsync(obj);
                await UnitOfWork.SaveChangesAsync();
                return "Delete Succesfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }        
    }
}
