namespace Core.Entites
{
    public class Owner : EntityBase
    {
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string FullName => $"{FName}  {LName} ";
        public string? Avatar { get; set; }
        public string? Profil { get; set; }
        public ICollection<Address> Address { get; set; } = new List<Address>();
    }
}
