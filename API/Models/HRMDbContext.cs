using API.DTO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class HRMDbContext : IdentityDbContext<CustomUser>
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options)
            : base(options)
        {
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<FormType> FormTypes { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Form>()
                .HasOne(f => f.FormType)
                .WithMany(ft => ft.Forms)
                .HasForeignKey(f => f.FormTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Form>()
                .HasOne(f => f.CustomUser)
                .WithMany(u => u.Forms)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Salary>()
                .HasOne(s => s.CustomUser)
                .WithMany(u => u.Salaries)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Salary>()
            //    .Property(s => s.FixedAmount)
            //    .HasColumnType("decimal(18, 2)");
        }
    }
}
