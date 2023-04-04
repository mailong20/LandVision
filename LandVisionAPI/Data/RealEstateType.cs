namespace LandVisionAPI.Data
{
    public class RealEstateType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RealEstate> RealEstates { get; set; }
    }
}
