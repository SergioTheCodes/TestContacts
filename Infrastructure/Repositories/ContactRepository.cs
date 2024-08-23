using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ContactRepository : RepositoryBase<Domain.Entities.Contact>
    {
        public ContactRepository(ContactContext contactContext) : base(contactContext)
        {
            
        }
    }
}
