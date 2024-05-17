using API.DTO;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public interface IFormService
    {
        Task<string> UploadFile(IFormFile file);

        Task<bool> SubmitForm(SubmitFormDTO formDto);

        Task<List<FormDTO>> GetUserFormsAsyncService(string userId, int? formTypeId);
    }
}
