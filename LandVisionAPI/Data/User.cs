using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace LandVisionAPI.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDelete { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }   
        public string? Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public int TypeUserId { get; set; }
        public TypeUser TypeUser { get; set; }
        public Account Account { get; set; }
        public ICollection<RealEstate> RealEstates { get; set; }
    }
}
