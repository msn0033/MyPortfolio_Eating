using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites
{
    public class Contact :EntityBase
    {

        public Guid? OwnerId { get; set; }
        public Owner? Owner { get; set; }
        public Guid? PhoneNumberId { get; set; }
        public PhoneNumber? PhoneNumber { get; set; }
        public ICollection<Address> Address { get; set; } = new List<Address>();

    }
}
