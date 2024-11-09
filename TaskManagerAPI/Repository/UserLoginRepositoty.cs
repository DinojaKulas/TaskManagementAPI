using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.Interface;
using TaskManagerAPI.Model;

namespace TaskManagerAPI.Repository
{
    public class UserLoginRepositoty: IUserLoginRepository
    {
        private readonly TaskContext _taskContext;

        public UserLoginRepositoty(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }
        public async Task<UserLogin>AddUser(UserLogin userLogin)
        {
            var userdetails = await _taskContext.AddAsync(userLogin);
            await _taskContext.SaveChangesAsync();
            return userdetails.Entity;
        }
        public async Task<UserLogin>GetUserByEmail(string Email)
        {
            var user = await _taskContext.userLogin.SingleOrDefaultAsync(u => u.Email== Email);
            return user!;
        }
    }
}
