using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LandVisionAPI.Data
{
    public class Media
    {
        public int Id { get; set; }
        public string MediaLink { get; set; }
        public int RealEstateId { get; set; }
        public RealEstate RealEstate { get; set; }
    }
}
