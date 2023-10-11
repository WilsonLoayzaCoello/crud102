using Microsoft.EntityFrameworkCore;

namespace _102Novadoc.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {
            
        }

        public DbSet<Entities.Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entities.Producto>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<Entities.Producto>()
            .Property(p => p.Category)
            .HasColumnType("char(3)");
        }
    }
}
