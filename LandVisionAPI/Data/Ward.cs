namespace LandVisionAPI.Data
{
    public class Ward
    {
        public int WardId { get; set; }
        public string WardName { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}
