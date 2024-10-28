using API.DTO;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _salaryService;

        public SalaryController(ISalaryService salaryService)
        {
            _salaryService = salaryService;
        }

        [HttpGet("getAllSalaries")]
        public async Task<IActionResult> GetAllSalaries()
        {
            var salaries = await _salaryService.GetAllSalaries();
            return Ok(salaries);
        }

        [HttpGet("getSalaryByUserId")]
        public async Task<IActionResult> GetSalaryByUserId(string userId)
        {
            var salary = await _salaryService.GetSalaryByUserId(userId);
            if (salary == null) return NotFound();
            return Ok(salary);
        }

        [HttpPost("addSalary")]
        public async Task<IActionResult> AddSalary([FromBody] SalaryDTO salaryDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdSalary = await _salaryService.CreateSalary(salaryDto);
            return CreatedAtAction(nameof(GetSalaryByUserId), new { id = createdSalary.Id }, createdSalary);
        }

        [HttpPut("updateSalary")]
        public async Task<IActionResult> UpdateSalary([FromBody] SalaryDTO salaryDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _salaryService.UpdateSalary(salaryDto);
            if (result != null) return NotFound();
            return NoContent();
        }

        [HttpDelete("deleteSalary")]
        public async Task<IActionResult> DeleteSalary(string id)
        {
            var result = await _salaryService.DeleteSalary(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
