using System.Diagnostics;

namespace LandVisionAPI.Data
{
    public class RealEstate
    {
        public int RealEstateId { get; set; }
        public string ResidentialAreaName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string RoomNumber { get; set; }
        public string SubdivisionName { get; set; }
        public string HouseType { get; set; }
        public int BedroomNumber { get; set; }
        public int BathroomNumber { get; set; }
        public string MainDoorDirection { get; set; }
        public int FloorNumber { get; set; }
        public string LegalPapers { get; set; }
        public string InteriorCondition { get; set; }
        public string PropertyFeatures { get; set; }
        public bool HasCarAlley { get; set; }
        public bool HasWiderBack { get; set; }
        public double LandArea { get; set; }
        public double UsableArea { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public int RealEstateTypeId { get; set; }
        public RealEstateType RealEstateType { get; set; }
        public ICollection<Media> Medias { get; set; }
        public Position Position { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }

    }
}
