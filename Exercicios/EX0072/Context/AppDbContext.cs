using Microsoft.EntityFrameworkCore;
using EX0072.Models;

namespace EX0072.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Cookie> Cookies { get; set; }
    }

}