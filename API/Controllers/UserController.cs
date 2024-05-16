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

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDTO signUpDTO)
        {
            try
            {
                var user = await _userService.SignUp(signUpDTO);
                return Ok(new { message = "Registration successful", userId = user.Id });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromBody] SignInDTO signInDTO)
        {
            try
            {
                var token = await _userService.SignIn(signInDTO);
                return Ok(new { message = "Sign-in successful", token });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("signInAuth")]
        [AllowAnonymous]
        public async Task<IActionResult> SignInAuth([FromBody] SignInDTO signInDTO)
        {
            var user = await _userManager.FindByNameAsync(signInDTO.Username);
            if(user != null && await _userManager.CheckPasswordAsync(user, signInDTO.Password))
            {
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                var userRole = await _userManager.GetRolesAsync(user);
                foreach (var role in userRole)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }
                var token = _tokenService.GetToken(authClaims);
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
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
        //[Authorize]
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
    }
}
