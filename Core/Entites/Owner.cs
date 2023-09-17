namespace Core.Entites
{
    public class Owner : EntityBase
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName => $"{FName}  {LName} ";
        public string Avatar { get; set; }
        public string Profil { get; set; }
        public Address Address { get; set; }
    }
}
