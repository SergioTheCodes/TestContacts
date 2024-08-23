using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contacts : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public int Id { get; set; }
    }
}
