using System.ComponentModel.DataAnnotations;

namespace xx1.Entities_Models_
{
    public class RoleEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
