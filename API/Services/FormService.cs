using API.DTO;
using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;

namespace API.Services
{
    public class FormService : IFormService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _customDirectory;
        private readonly IUnitOfWork _unitOfWork;

        public FormService(IWebHostEnvironment webHostEnvironment, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _customDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "Forms");

            if (!Directory.Exists(_customDirectory))
            {
                Directory.CreateDirectory(_customDirectory);
            }
        }

        public async Task<string> UploadFile(IFormFile file)
        {
            if (file.Length > 0)
            {
                try
                {
                    var filePath = Path.Combine(_customDirectory, file.FileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }

                    var projectRoot = Directory.GetCurrentDirectory();
                    var relativePath = filePath.Replace(projectRoot, "").TrimStart(Path.DirectorySeparatorChar);

                    return relativePath;
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
            else
            {
                return "Upload failed, file is empty.";
            }
        }

        public async Task<bool> SubmitForm(SubmitFormDTO submitformDto)
        {
            var filePath = await UploadFile(submitformDto.FileUpload);

            if (filePath.StartsWith("Upload failed"))
            {
                return false;
            }

            var form = new FormDTO
            {
                Title = submitformDto.Title,
                Reason = submitformDto.Reason,
                Description = submitformDto.Description,
                CreatedDate = DateTime.UtcNow,
                FilePath = filePath,
                UserId = submitformDto.UserId,
                FormTypeId = submitformDto.FormTypeId,
            };
            await _unitOfWork.FormDTOs.AddEntity(form);
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<List<FormDTO>> GetUserFormsAsyncService(string userId, int? formTypeId)
        {
            var query = _unitOfWork.FormDTOs.GetUserFormsAsync(userId, formTypeId);
            await _unitOfWork.CompleteAsync();
            return await query;
        }
    }
}
