using API.DTO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class HRMDbContext : IdentityDbContext<CustomUser>
    {
        public HRMDbContext()
        {
        }
        public HRMDbContext(DbContextOptions<HRMDbContext> options)
       : base(options)
        {
        }
    }
}
