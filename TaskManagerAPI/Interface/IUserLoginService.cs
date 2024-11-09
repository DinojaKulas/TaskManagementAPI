using TaskManagerAPI.DTO.Request;
using TaskManagerAPI.DTO.Response;

namespace TaskManagerAPI.Interface
{
    public interface IUserLoginService
    {
        Task<UserLoginResponse> AddUser(UserLoginRequest userLoginRequest);

    }
}
