using API.DTO;
using API.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //this.SeedRoles(builder);
        }

        //private void SeedRoles(ModelBuilder builder)
        //{
        //    var roles = LocalRoles.GetAllRoles()
        //        .Select(role => new IdentityRole
        //        {
        //            Name = role.Name,
        //            NormalizedName = role.NormalizedName,
        //            ConcurrencyStamp = role.ConcurrencyStamp,
        //        })
        //        .ToList();

        //    foreach (var role in roles)
        //    {
        //        builder.Entity<IdentityRole>().HasData(new IdentityRole() { Id = role.Id, Name = role.Name, NormalizedName = role.NormalizedName, ConcurrencyStamp = role.ConcurrencyStamp });
        //    }
        //}
    }
}
