using Microsoft.EntityFrameworkCore;
using Productapi.Models;

namespace Productapi.Date
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(option){}

        public DbSet<Product> Products {get; set;}
    }
}