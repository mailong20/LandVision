using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandVisionAPI.Data
{
    public class TypeUser
    {
        public TypeUser()
        {
            Users = new List<User>();
        }
        public int TypeUserId { get; set; }
        public string Name { get; set; }
        public  ICollection<User> Users { set; get; }
        public ICollection<TypeUserRole> TypeUserRoles { set; get; }
    }
}
