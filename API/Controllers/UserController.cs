using API.DTO;
using API.Helpers;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(Roles = LocalRoles.Admin + "," + LocalRoles.HR)]
    public class UserController : ControllerBase
    {
        private readonly ILogger <UserController> _logger;
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        private readonly UserManager<CustomUser> _userManager;

        public UserController(ILogger<UserController> logger, IUserService userService, ITokenService tokenService, UserManager<CustomUser> userManager)
        {
            _logger = logger;
            _userService = userService;
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [HttpGet("getAllUser")]
        public async Task<ActionResult<CustomUser>> GetAllUser()
        {
            try
            {
                var users = await _userService.GetAllUser();
                return Ok(users);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addUser")]
        public async Task<IActionResult> AddUser([FromBody] SignUpDTO customUser, string role)
        {
            var user = await _userService.AddUser(customUser, role);
            if (!user)
            {
                return BadRequest("User already exist or Role doesn't exist");
            }
            else
            {
                return Ok("User create successfully");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var result = await _userService.DeleteUser(id);
            if (result)
            {
                return Ok(new { message = "User deleted successfully." });
            }
            return NotFound(new { message = "User not found." });
        }

        [HttpGet("username/{name}")]
        public async Task<IActionResult> GetUserByUserName(string name)
        {
            var result = await _userService.GetUserByUserName(name);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(new { message = "User not found." });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(CustomUser entity)
        {
            var result = await _userService.UpdateUser(entity);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(new { message = "Update failed." });
        }

    }
}
