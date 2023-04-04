using System.Xml;

namespace LandVisionAPI.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAction { get; set; }
        public DateTime PostDate { get; set; }
        public int PostTypeId { get; set; }
        public PostType PostTypeOfPost { get; set; }
        public int RealEstateId { get; set; }
        public RealEstate RealEstate { get; set; }
        
    }
}
