namespace ASPDotNetCoreWepAPI.Data;
using Microsoft.EntityFrameworkCore;
using ASPDotNetCoreWepAPI.Models;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Job> Jobs => Set<Job>();
}