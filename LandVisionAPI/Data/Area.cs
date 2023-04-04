using System.Diagnostics;

namespace LandVisionAPI.Data
{
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public ICollection<Ward> Wards { set; get; }
    }
}
