using API.DTO;
using API.Helpers;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = LocalRoles.Admin + "," + LocalRoles.HR + "," + LocalRoles.Accountant + "," + LocalRoles.BA + "," + LocalRoles.Employee + "," + LocalRoles.Manager)]
        public async Task<IActionResult> SubmitForm([FromForm] SubmitFormDTO submitformDto)
        {
            if (submitformDto.FileUpload == null || submitformDto.FileUpload.Length == 0)
            {
                return BadRequest("File is required.");
            }

            var result = await _formService.SubmitForm(submitformDto);
            if (result)
            {
                return Ok("Form submitted successfully.");
            }
            else
            {
                return StatusCode(500, "There was an error submitting the form.");
            }
        }
        [HttpGet("getUserForms")]
        [Authorize(Roles = LocalRoles.Admin + "," + LocalRoles.Manager)]
        public async Task<IActionResult> GetUserForms(string userId, int formTypeId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                return BadRequest("User ID is required");
            }

            var forms = await _formService.GetUserFormsAsyncService(userId, formTypeId);

            if (forms == null || forms.Count == 0)
            {
                return NotFound("No forms found");
            }

            return Ok(forms);

        }
    }
}
