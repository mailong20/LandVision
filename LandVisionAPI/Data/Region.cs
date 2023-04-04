namespace LandVisionAPI.Data
{
    public class Region
    {
        public int RegionId { set; get; }
        public string RegionName { set; get; }
        public ICollection<Area> Areas { set; get; }
    }
}
