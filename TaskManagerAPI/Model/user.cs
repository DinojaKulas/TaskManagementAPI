using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string phone { get; set; }
   
        public Address? Address { get; set; }
        public ICollection<TaskItem>? Tasks { get; set; }
    }
}
