using Microsoft.EntityFrameworkCore;
using Finyx.Domain.Entities;

namespace Finyx.DAL.DbContext
{
    public class FinyxDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public FinyxDbContext(DbContextOptions<FinyxDbContext> options) : base(options)
        {
        }

        // DbSets for entities will be added here when entities are created
        // Example:
        // public DbSet<User> Users { get; set; }
        // public DbSet<Document> Documents { get; set; }
        // public DbSet<Report> Reports { get; set; }
        // public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure global query filters for soft delete
            modelBuilder.Entity<BaseEntity>()
                .HasQueryFilter(e => !e.IsDeleted);

            // Configure common properties
            modelBuilder.Entity<BaseEntity>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<BaseEntity>()
                .Property(e => e.IsDeleted)
                .HasDefaultValue(false);

            // Configure AuditableEntity properties
            modelBuilder.Entity<AuditableEntity>()
                .Property(e => e.LastModifiedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            // Add any additional entity configurations here
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // This will be overridden by dependency injection configuration
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }
    }
}
