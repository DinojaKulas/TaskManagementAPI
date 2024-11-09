using TaskManagerAPI.DTO.Request;
using TaskManagerAPI.DTO.Response;
using TaskManagerAPI.Interface;
using TaskManagerAPI.Model;

namespace TaskManagerAPI.Service
{
    public class UserLoginService: IUserLoginService
    {
        private readonly IUserLoginRepository _repository;

        public UserLoginService(IUserLoginRepository repository)
        {
            _repository = repository;
        }
        public async Task<UserLoginResponse>AddUser(UserLoginRequest userLoginRequest)
        {
            var user = await _repository.GetUserByEmail(userLoginRequest.Email);
            if (user == null)
            {
                var userObj = new UserLogin()
                {
                    FullName= userLoginRequest.FullName,
                    Email= userLoginRequest.Email,
                    Password= userLoginRequest.Password,
                    Role=((RoleType)userLoginRequest.Role).ToString(),

                };
                var userdata = await _repository.AddUser(userObj);
                var response = new UserLoginResponse()
                {
                    Id = userdata.Id,
                    FullName= userdata.FullName,
                    Email= userdata.Email,
                    Role= userdata.Role,

                };
                return response;
            }
            else
            {
                throw new Exception("User already exit");
            }
            

            




        }
    }
}
