using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class SignUpDTO
    {
        public string? Username { get; set; }

        public string? Password { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }
    }
}
