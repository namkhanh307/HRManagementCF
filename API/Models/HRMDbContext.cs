using API.DTO;
using API.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Emit;

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Form>()
                .HasOne(f => f.FormType)
                .WithMany(ft => ft.Forms)
                .HasForeignKey(f => f.FormTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Salary>()
                .HasOne(s => s.CustomUser)
                .WithMany(u => u.Salaries)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FormType>()
                .HasMany(ft => ft.Forms)
                .WithOne(f => f.FormType)
                .HasForeignKey(f => f.FormTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Salary>()
        .Property(s => s.FixedAmount)
        .HasColumnType("decimal(18, 2)"); //
        }
    }
    
}
