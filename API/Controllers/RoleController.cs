using API.DTO;
using API.Helpers;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = LocalRoles.Admin)]
    public class RoleController : ControllerBase
    {
        private readonly HRMDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<CustomUser> _userManager;
        private readonly ILogger<RoleController> _logger;
        private readonly IUserService _userService;


        public RoleController(HRMDbContext context, UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, ILogger<RoleController> logger, IUserService userService)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("getAllRole")]
        public ActionResult GetAllRole()
        {
            var roles = _roleManager.Roles.ToList();
            return Ok(roles);
        }

        [HttpPut("modifyRole")]
        public async Task<ActionResult> ModifyRole([FromBody] string username, string roleName)
        {
            //var result = await _userService.ModifyRole(username, roleName);

            //if(result)
            //{
            //    return Ok("Modify role successfully");
            //}
            //return BadRequest("Username or rolename doesn't exist");

            var existRole = await _roleManager.FindByNameAsync(roleName);
            var existUsername = await _userService.GetUserByUserName(username);
            if (existRole == null || existUsername == null)
            {
                return BadRequest("Username or role doesn't exist!");
            }
            else
            {
                await _userManager.AddToRoleAsync(existUsername, roleName);
                return Ok("Role modify succesfully");
            }
        }

        [HttpPost("addRole")]
        [Authorize(Policy = "ApiAccess:addRole")]
        public async Task<IActionResult> CreateRole([FromBody] string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                return BadRequest("Role name is required");
            }

            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (roleExists)
            {
                return BadRequest("Role already exists");
            }

            var role = new IdentityRole(roleName)
            {
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return Ok("Role created successfully");
            }
            else
            {
                return BadRequest("Role could not be created");
            }
        }
    }
}
