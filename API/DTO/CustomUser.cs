using API.Models;
using Microsoft.AspNetCore.Identity;

namespace API.DTO
{
    public class CustomUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public virtual ICollection<Form> Forms { get; set; } = new List<Form>();

        public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>(); 
    }
}
