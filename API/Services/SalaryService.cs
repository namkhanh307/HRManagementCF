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
        public async Task<double> CalculateMonthlySalaryAsync(string userId, int month, int year)
        {
            var salary = await _unitOfWork.Salaries.CalculateMonthlySalaryRepo(userId, month, year);
            await _unitOfWork.CompleteAsync();
            return salary;
        }
    }
}
