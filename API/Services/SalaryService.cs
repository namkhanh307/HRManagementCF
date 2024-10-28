using API.DTO;
using API.Models;
using API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class SalaryService : ISalaryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SalaryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<SalaryDTO>> GetAllSalaries()
        {
            var result = await _unitOfWork.Salaries.GetAllSalariesAsync();
            await _unitOfWork.CompleteAsync();
            return result;
        }

        public async Task<SalaryDTO?> GetSalaryByUserId(string id)
        {
            var salary = await _unitOfWork.Salaries.GetSalaryByUser(id);
            await _unitOfWork.CompleteAsync();
            return salary;
            
        }

        public async Task<SalaryDTO> CreateSalary(SalaryDTO salaryDto)
        {
            await _unitOfWork.Salaries.AddEntity(salaryDto);
            await _unitOfWork.CompleteAsync();
            return salaryDto;
        }

        public Task<SalaryDTO> UpdateSalary(SalaryDTO salaryDto)
        { 
            var result = _unitOfWork.Salaries.UpdateEntity(salaryDto);
            _unitOfWork.CompleteAsync();
            return result;
        }

        public Task<bool> DeleteSalary(string id)
        {
            var result = _unitOfWork.Salaries.DeleteEntity(id);
            _unitOfWork.CompleteAsync();
            return result;
        }
    }
}
