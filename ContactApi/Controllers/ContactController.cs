using Domain.Entities;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        [Route("GetContactById")]
        public async Task<Contacts> GetContactById(int id)
        {
            try
            {
                var contacts = await _contactService.GetContactById(id);
                return contacts;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("GetContacts")]
        public async Task<List<Contacts>> GetContacts()
        {
            try
            {
                var contacts = await _contactService.GetContacts();
                return contacts;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("AddContact")]
        public async Task<string> AddContact(Contacts contact)
        {
            try
            {
                return await _contactService.AddContact(contact);
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpPut]
        [Route("UpdateContact")]
        public async Task<string> UpdateContact(Contacts contact)
        {
            try
            {
                return await _contactService.UpdateContact(contact);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpDelete]
        [Route("DeleteContact")]
        public async Task<string> DeleteContact(Contacts contact)
        {
            try
            {
                return await _contactService.DeleteContact(contact);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }        
    }
}
