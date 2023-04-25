using Allasborze.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Allasborze.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<AllasModel> Allasok { get; set; }
        DbSet<AllasUser> Felhasznalok { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}