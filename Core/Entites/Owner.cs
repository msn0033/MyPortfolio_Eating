namespace Core.Entites
{
    public class Owner : EntityBase
    {
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Avatar { get; set; }
        public string? Profil { get; set; }
        public string FullName => $"{FName}  {LName} ";
        public Contact? Contact { get; set; }
        public ICollection<PortFolioItem> PortFolioItem { get; set; } = new List<PortFolioItem>();
    }
}
