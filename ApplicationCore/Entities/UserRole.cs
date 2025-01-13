using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class UserRole
    {
        public int RoleId { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
