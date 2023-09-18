namespace Core.Entites
{
    public class PortFolioItem : EntityBase
    {
        public string? ProjectName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public Guid? OwnerId { get; set; }
        public Owner? Owner { get; set; }

    }
}
