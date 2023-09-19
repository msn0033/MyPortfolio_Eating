using Core;
using Core.Entites;
using System.Linq.Expressions;

namespace Web.ViewModels
{
    public class HomeVM
    {
        public Owner? Owner { get; set; }
        public ICollection< Address>? Address { get; set; }
        public Contact? Contact { get; set; }
        public PhoneNumber? PhoneNumber { get; set; }
        public ICollection<PortFolioItem>? PortFolioItems { get; set; }
    }
}
