using API.DTO;
using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserService> _logger;
        private readonly ITokenService _tokenService;
        private readonly UserManager<CustomUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(IUnitOfWork unitOfWork, ILogger<UserService> logger, ITokenService tokenService, UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _tokenService = tokenService;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<CustomUser> SignUp(SignUpDTO signUpDTO)
        {
            if (await _userManager.Users.AnyAsync(m => m.UserName == signUpDTO.Username))
            {
                throw new Exception("User name is already exist!");
            }

            var user = new CustomUser
            {
                UserName = signUpDTO.Username,
                Email = signUpDTO.Email,
                FirstName = signUpDTO.Name,
            };

            var result = await _userManager.CreateAsync(user, signUpDTO.Password);

            if (result.Succeeded)
            {
                await _unitOfWork.CompleteAsync();
                return user;
            }
            else
            {
                result.Errors.ToList().ForEach(e =>
                {
                    throw new Exception(e.Description);
                });

                return null;
            }
        }
        public async Task<string> SignIn(SignInDTO signInDTO)
        {
            var user = await _userManager.FindByNameAsync(signInDTO.Username);

            if (user == null) {
                throw new Exception("User does not exist");
            }
            else
            {
                var result = await _userManager.CheckPasswordAsync(user, signInDTO.Password);
                if (result)
                {
                    await _unitOfWork.CompleteAsync();
                    return _tokenService.GenerateJwtToken(user);
                }
                return null;
            }
        }
        public async Task<bool> AddUser(SignUpDTO user, string role)
        {
            CustomUser customUser = new()
            {
                UserName = user.Username,
                Email = user.Email,
                PasswordHash = _tokenService.Hash(user.Password)
            };
            if(await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(customUser);
                if(!result.Succeeded)
                {
                    return false;
                }
                await _userManager.AddToRoleAsync(customUser, role);
                await _unitOfWork.CompleteAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<bool> DeleteUser(string id)
        {
            var result = _unitOfWork.Users.DeleteEntity(id);
            _unitOfWork.CompleteAsync();
            return result;
        }

        public Task<List<CustomUser>> GetAllUser()
        {
            var result = _unitOfWork.Users.GetAllEntity();
            _unitOfWork.CompleteAsync();
            return result;
        }

        public Task<CustomUser> GetUserByID(string id)
        {
            var result = _unitOfWork.Users.GetEntityByID(id);
            _unitOfWork.CompleteAsync();
            return result;
        }

        public Task<CustomUser> UpdateUser(CustomUser entity)
        {
            var result = _unitOfWork.Users.UpdateEntity(entity);
            _unitOfWork.CompleteAsync();
            return result;
        }

        public async Task<bool> ModifyRole(string username, string role)
        {
            var existRole = await _roleManager.FindByNameAsync(role);
            var existUsername = await _unitOfWork.Users.GetEntityByUsername(username);
            if(existRole == null || existUsername == null) {
                return false;
            }
            else
            {
                await _userManager.AddToRoleAsync(existUsername, role);
                await _unitOfWork.CompleteAsync();
                return true;
            }
        }
    }
}
