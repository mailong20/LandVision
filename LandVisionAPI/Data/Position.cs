namespace LandVisionAPI.Data
{
    public class Position
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude  { get; set; }
        public int RealEstateId { get; set; }
        public RealEstate RealEstate { get; set; }
    }
}
