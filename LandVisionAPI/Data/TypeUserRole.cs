namespace LandVisionAPI.Data
{
    public class TypeUserRole
    {
        public int TypeUserId { get; set; }
        public string RoleId { get; set; }
        public TypeUser TypeUser { get; set; }
        public Role Role { get; set; }

    }
}
