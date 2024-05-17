using API.DTO;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public double? FixedAmount { get; set; }
        public string? UserId { get; set; }
        public CustomUser? CustomUser { get; set; }
    }
}
