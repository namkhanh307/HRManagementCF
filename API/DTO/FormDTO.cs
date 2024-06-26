﻿using API.Models;

namespace API.DTO
{
    public class FormDTO
    {
        public string? Title { get; set; }
        public string? Reason { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FilePath { get; set; }
        public IFormFile FileUpload { get; set; }
        public int? FormTypeId { get; set; }
        public string? UserId { get; set; }
    }
}
