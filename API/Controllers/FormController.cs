using API.DTO;
using API.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpPost("submitForm")]
        public async Task<IActionResult> SubmitForm([FromForm] FormDTO formDto)
        {
            if (formDto.FileUpload == null || formDto.FileUpload.Length == 0)
            {
                return BadRequest("File is required.");
            }

            var result = await _formService.SubmitForm(formDto);
            if (result)
            {
                return Ok("Form submitted successfully.");
            }
            else
            {
                return StatusCode(500, "There was an error submitting the form.");
            }
        }
    }
}
