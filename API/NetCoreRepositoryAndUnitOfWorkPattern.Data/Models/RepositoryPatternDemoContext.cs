using Microsoft.EntityFrameworkCore;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Data.Models
{
    public partial class RepositoryPatternDemoContext : DbContext
    {
        public RepositoryPatternDemoContext()
        {
        }

        public RepositoryPatternDemoContext(DbContextOptions<RepositoryPatternDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
