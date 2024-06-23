using System.Reflection;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Requirement> Requirements { get; set; }
    public DbSet<Learning> Learnings { get; set; }
    public DbSet<Category> Categories { get; set; }
}