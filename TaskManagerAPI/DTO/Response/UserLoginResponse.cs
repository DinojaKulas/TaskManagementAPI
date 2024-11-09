using TaskManagerAPI.Model;

namespace TaskManagerAPI.DTO.Response
{
    public class UserLoginResponse
    {
      public Guid Id { get; set; }
        public string FullName { get; set; }
      
        public string Email { get; set; }
         
        public string Role { get; set; }
    }
}
