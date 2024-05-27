using Microsoft.AspNetCore.Mvc;
//using Mfund.Service;
using MutualFund.Service;

namespace Mfund.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       // private readonly UserService _userService;
         private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("User/login")]

        public async Task<IActionResult> LoginAsync()
        {
            try
            {
                var result = await _userService.LoginAsync();
                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");

            }
        }

        [HttpPost("User/generateToken")]

        public async Task<IActionResult> TokenAsync()
        {
            try
            {
                var result = await _userService.TokenAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

        [HttpGet("User/GetProfile")]

        public async Task<IActionResult> GetProfileAsync()
        {
            try
            {
                var result = await _userService.GetProfileAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

        [HttpPost("User/GetRMS")]

        public async Task<IActionResult> GetRMSAsync()
        {
            try
            {
                var result = await _userService.GetRMSAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

        [HttpPost("User/logOut")]

        public async Task<IActionResult> logOutAsync()
        {
            try
            {
                var result = await _userService.logOutAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error:{ex.Message}");
            }
        }

    }
}
