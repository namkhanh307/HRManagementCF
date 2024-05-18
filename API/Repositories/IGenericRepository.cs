using API.DTO;
using API.Models;

namespace API.Repositories
{
    public interface IGenericRepository<T> where T : class
    {

        //Task<CustomUser> SignUp(SignUpDTO signUpDTO);
        //Task<string> SignIn(SignInDTO signInDTO);

        Task<List<T>> GetAllEntity();

        Task<T> GetEntityByID(string id);

        Task<bool> AddEntity(T entity);

        Task<T> UpdateEntity(T entity);

        Task<bool> DeleteEntity(string id);

        Task<CustomUser> GetEntityByName(string username);
        Task<List<FormDTO>> GetUserFormsAsync(string userId, int? formTypeId);
        Task<double> CalculateMonthlySalaryRepo(string userId, int month, int year);
        Task<List<Form>> GetFormsByUserIdAndTypeAsync(string userId, int formTypeId, int month, int year);

    }
}
