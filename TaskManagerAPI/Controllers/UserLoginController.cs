using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.DTO.Request;
using TaskManagerAPI.Interface;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IUserLoginService _userLoginService;

        public UserLoginController(IUserLoginService userLoginService)
        {
            _userLoginService = userLoginService;
        }
        [HttpPost("Add_User")]
        public async Task<IActionResult> AddUser(UserLoginRequest userLoginRequest)
        {
            try
            {
                var userdata = await _userLoginService.AddUser(userLoginRequest);
                return Ok(userdata);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }

        }
    }
}
