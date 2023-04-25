using Allasborze.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Allasborze.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<AllasModel> Allasok { get; set; }
        public DbSet<AllasUser> Felhasznalok { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AllasModel>()
                .HasMany(t => t.Dolgozok)
                .WithMany();

            builder.Entity<AllasUser>()
                .HasMany(t => t.Allasok)
                .WithMany();

            base.OnModelCreating(builder);
        }
    }
}