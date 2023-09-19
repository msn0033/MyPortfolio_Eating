using Core.Entites;
using Core;

namespace Web.ViewModels
{
    public class PortFolioItemVM : EntityBase
    {
        public string? ProjectName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public  IFormFile? Formfile { get; set; }
        public Guid? OwnerId { get; set; }
        public Owner? Owner { get; set; }

    }
}
