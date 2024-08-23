using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Service;
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

        public async Task<string> AddContact(Contact contact)
        {
            var repository = UnitOfWork.AsyncRepository<Contact>();
            
            try
            {
                await repository.AddAsync(contact);
                await UnitOfWork.SaveChangesAsync();
                return "Contact Added SuccessFully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<string> UpdateContact(Contact contact)
        {
            var repository = UnitOfWork.AsyncRepository<Contact>();
            try
            {
                await repository.UpdateAsync(contact);
                await UnitOfWork.SaveChangesAsync();
                return "Contact Updated";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<List<Contact>> GetContacts()
        {
            var repository = UnitOfWork.AsyncRepository<Contact>();
            try
            {
                var contacts = await repository.ListAsync(_ => _.Id > 0);
                return contacts;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<string> DeleteContact(Contact contact)
        {
            var repository = UnitOfWork.AsyncRepository<Contact>();
            try
            {
                await repository.DeleteAsync(contact);
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
