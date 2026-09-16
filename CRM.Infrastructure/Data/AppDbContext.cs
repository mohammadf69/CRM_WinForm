using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Interaction> Interactions => Set<Interaction>();
    public DbSet<FollowUp> FollowUps => Set<FollowUp>();
    public DbSet<TaskItem> Tasks => Set<TaskItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}