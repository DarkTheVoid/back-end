using Microsoft.EntityFrameworkCore;
using _19_Admin.Models;

namespace _19_Admin.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Continente> Continentes { get; set; }
    }
}