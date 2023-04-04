namespace LandVisionAPI.Data
{
    public class Role
    {
        public string RoleId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<TypeUserRole> TypeUserRoles { set; get; }
    }
}
