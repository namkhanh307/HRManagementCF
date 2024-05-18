using API.DTO;

namespace API.Models
{
    public class Form
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Reason { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? FilePath { get; set; }
        public int? DayQuantity { get; set; } 
        public int? FormTypeId { get; set; }
        public string? UserId { get; set; }
        public CustomUser? CustomUser { get; set; }
        public FormType? FormType { get; set; }
    }
}
