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
        [Route("GetContacts")]
        public async Task<List<Contact>> GetContacts()
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
        public async Task<string> AddContact(Contact contact)
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
        public async Task<string> UpdateContact(Contact contact)
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
        public async Task<string> DeleteContact(Contact contact)
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
