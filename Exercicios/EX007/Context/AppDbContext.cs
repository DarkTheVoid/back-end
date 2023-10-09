using Microsoft.EntityFrameworkCore;
using EX007.Models;

namespace EX007.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }

        public DbSet<Cookie> Cookies {get; set;}
    }
}