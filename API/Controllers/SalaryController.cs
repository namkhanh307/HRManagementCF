using API.DTO;
using API.Helpers;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = LocalRoles.Accountant)]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _salaryService;

        public SalaryController(ISalaryService salaryService)
        {
            _salaryService = salaryService;
        }

        [HttpGet("calculateMonthlySalary")]
        public async Task<IActionResult> CalculateMonthlySalary(string userId, int month, int year)
        {
            try
            {
                var monthlySalary = await _salaryService.CalculateMonthlySalaryAsync(userId, month, year);
                var response = new SalaryCalculationDTO
                {
                    MonthlySalary = monthlySalary
                };
                return Ok(response);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Salary or forms not found for the specified user");
            }
        }
    }
}
