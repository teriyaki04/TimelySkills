using Microsoft.EntityFrameworkCore;
using TimelySkills.Core.Entities;
using TimelySkills.Infrastructure.Configurations;

namespace TimelySkills.Infrastructure.Context;

public sealed class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        :base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
}