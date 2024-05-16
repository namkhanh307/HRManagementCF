using Microsoft.AspNetCore.Identity;

namespace API.DTO
{
    public class CustomUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
