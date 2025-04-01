using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;

public class ApplicationDbContext : DbContext
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(Directory.GetCurrentDirectory()).FullName) // Dynamic base path
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseNpgsql(connectionString); // UseNpgsql for PostgreSQL
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure primary key for Project
        modelBuilder.Entity<Project>()
            .HasKey(p => p.PrijectID);

        // Configure primary key for Task
        modelBuilder.Entity<Task>()
            .HasKey(t => t.TaskID);

        // Configure primary key for User
        modelBuilder.Entity<User>()
            .HasKey(u => u.UserID);

        // One Project has many Tasks
        modelBuilder.Entity<Project>()
            .HasMany(p => p.Tasks)
            .WithOne(t => t.Project)
            .HasForeignKey(t => t.ProjectID);

        // One Project has one Manager (User)
        modelBuilder.Entity<Project>()
            .HasOne(p => p.Manager)
            .WithMany()
            .HasForeignKey(p => p.ManagerID);

        // One Task has one User
        modelBuilder.Entity<Task>()
            .HasOne(t => t.Assignee)
            .WithMany()
            .HasForeignKey(t => t.AssigneeId);
    }
}