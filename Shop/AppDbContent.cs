using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop
{
    public class AppDbContent : DbContext
    {
        public DbSet<UserModel> user { get; set; }
        public DbSet<ProductModel> product { get; set; }

        public AppDbContent() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-Q6M74QL\SQLEXPRESS;Database=ShopDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>()
                .HasOne(b => b.User) 
                .WithMany(a => a.favouriteProducts)  
                .HasForeignKey(b => b.userId); 
        }
    }
}
