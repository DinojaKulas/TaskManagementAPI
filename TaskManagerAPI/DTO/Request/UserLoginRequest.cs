using TaskManagerAPI.Model;

namespace TaskManagerAPI.DTO.Request
{
    public class UserLoginRequest
    {
       
        public string FullName { get; set; }
    
        public string Email { get; set; }
    
        public string Password { get; set; }
            
   
        public RoleType Role { get; set; }
    }
}
