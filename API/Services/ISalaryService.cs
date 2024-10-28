using API.DTO;

namespace API.Services
{
    public interface ISalaryService
    {
        Task<List<SalaryDTO>> GetAllSalaries();
        Task<SalaryDTO> GetSalaryByUserId(string id);
        Task<SalaryDTO> CreateSalary(SalaryDTO salaryDto);
        Task<SalaryDTO> UpdateSalary(SalaryDTO salaryDto);
        Task<bool> DeleteSalary(string id);
    }
}
