using API.DTO;

namespace API.Services
{
    public interface ISalaryService
    {
        Task<double> CalculateMonthlySalaryAsync(string userId, int month, int year);

    }
}
