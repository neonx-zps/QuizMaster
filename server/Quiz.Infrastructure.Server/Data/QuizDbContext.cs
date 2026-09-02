using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;

namespace Quiz.Infrastructure.Server.Data;

public class QuizDbContext : DbContext
{
    public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
    {
    }

    public DbSet<TestEntity> Tests { get; set; }
    public DbSet<TestResultEntity> TestResults { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<TestEntity>()
            .HasMany(t => t.Results)
            .WithOne()
            .HasForeignKey(r => r.TestId);
    }
}
