using System.ComponentModel.DataAnnotations;

namespace xx1.Entities_Models_
{
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public int RoleId { get; set; }

        public virtual RoleEntity? Role { get; set; }
    }
}
