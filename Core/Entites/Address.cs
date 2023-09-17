using Core.Entites;

namespace Core
{
    public class Address :EntityBase
    {

        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid OwnerId { get; set; }
        public Owner? Owner { get; set; }

    }
}
