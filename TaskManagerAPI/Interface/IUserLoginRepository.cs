using TaskManagerAPI.Model;

namespace TaskManagerAPI.Interface
{
    public interface IUserLoginRepository
    {
        Task<UserLogin> AddUser(UserLogin userLogin);
        Task<UserLogin> GetUserByEmail(string Email);
    }
}
