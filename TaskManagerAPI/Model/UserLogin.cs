using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Model
{
    public class UserLogin
    {
        public Guid Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
      
        [Required]
        public string Role { get; set; }

    }
    public enum RoleType
    {
        Admin,
        viewer,
        Editor
    }
}
