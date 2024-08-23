using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ContactRepository : RepositoryBase<Infrastructure.Data.Contact>
    {
        public ContactRepository(ContactContext contactContext) : base(contactContext)
        {
            
        }
    }
}
