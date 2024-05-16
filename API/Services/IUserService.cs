using API.DTO;
using API.Models;
using Microsoft.AspNetCore.Identity;

namespace API.Services
{
    public interface IUserService
    {
        Task<List<CustomUser>> GetAllUser();

        Task<CustomUser> GetUserByID(string id);

        Task<bool> AddUser(SignUpDTO entity, string role);

        Task<CustomUser> UpdateUser(CustomUser entity);

        Task<bool> DeleteUser(string id);

        Task<CustomUser> SignUp(SignUpDTO signUpDTO);
        Task<string> SignIn(SignInDTO signInDTO);

        Task<bool> ModifyRole(string username, string role);
    }
}
