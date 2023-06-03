using Microsoft.EntityFrameworkCore;
using TspuWeb.Models;

namespace TspuWeb.Repositories
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<dbProducts> dbProducts { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        { } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public"); 

            modelBuilder.Entity<dbProducts>(b =>
            {
                b.ToTable("products"); 
                b.HasKey(u => u.Id); 
                b.Property(user => user.Id).HasColumnName("id"); 
                b.Property(user => user.Name).HasColumnName("Name"); 
                b.Property(user => user.Description).HasColumnName("Description"); 
                b.Property(user => user.Price).HasColumnName("Price"); 
                b.Property(user => user.IsDeleted).HasColumnName("IsDeleted"); 
            });

        }
    }
}
