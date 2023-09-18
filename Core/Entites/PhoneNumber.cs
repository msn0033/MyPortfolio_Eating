using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites
{
    public class PhoneNumber : EntityBase
    {
        public string? n1 { get; set; }
        public string? n2 { get; set; }
        public string? n3 { get; set; }
        public Contact? Contact { get; set; }

    }
}
