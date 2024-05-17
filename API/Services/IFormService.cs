using API.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public interface IFormService
    {
        Task<string> UploadFile(IFormFile file);

        Task<bool> SubmitForm(FormDTO formDto);

    }
}
