using Core.Entites;

namespace Core
{
    public class Address :EntityBase
    {

        public string? Street { get; set; }
        public string? City { get; set; }
        public bool MainAddress { get; set; }
        public Guid? ContactId { get; set; }
        public Contact? Contact { get; set; }



    }
}
