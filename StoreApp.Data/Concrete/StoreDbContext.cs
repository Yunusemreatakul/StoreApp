using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;

namespace StoreApp.Data.Concrete
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                        .HasMany(e => e.Categories)
                        .WithMany(e =>e.products)
                        .UsingEntity<ProductCategory>();
            modelBuilder.Entity<Category>()
                        .HasIndex(u => u.Url)
                        .IsUnique();

            modelBuilder.Entity<Product>().HasData(
                new List<Product>() {
                    new() {Id=1,Name="Samsung s16", Price=25000,Description="Akıllı Telefon"},
                    new() {Id=2,Name="Samsung s17", Price=26000,Description="Baya Akıllı Telefon"},
                    new() {Id=3,Name="Samsung s18", Price=27000,Description="Çok Akıllı Telefon"},
                    new() {Id=4,Name="Samsung s19", Price=28000,Description="En Akıllı Telefon"},
                    new() {Id=5,Name="Samsung s20", Price=29000,Description="En En Akıllı Telefon"},
                    new() {Id=6,Name="Samsung s21", Price=30000,Description="Senden Akıllı Telefon"},
                    new() {Id=7,Name="Televizyon", Price=31000,Description="yeni model Akıllı TV"},
                    new() {Id=8,Name="Buz Dolabı", Price=32000,Description="Inanılmaz zeki ve Akıllı Dolap"}
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new List<Category>()
                {
                    new() {Id=1, Name="Telefon",Url="telefon"},
                    new() {Id=2, Name="Elektronik",Url="elektronik"},
                    new() {Id=3, Name="Beyaz eşya",Url="beyaz-esya"},
                }
            );
            modelBuilder.Entity<ProductCategory>()
                        .HasData(
                            new List<ProductCategory>() {
                                new ProductCategory() {ProductId= 1 , CategoryId=1},
                                new ProductCategory() {ProductId= 2 , CategoryId=1},
                                new ProductCategory() {ProductId= 3 , CategoryId=1},
                                new ProductCategory() {ProductId= 4 , CategoryId=1},
                                new ProductCategory() {ProductId= 5 , CategoryId=1},
                                new ProductCategory() {ProductId= 6 , CategoryId=1},
                                new ProductCategory() {ProductId= 7 , CategoryId=2},
                                new ProductCategory() {ProductId= 8 , CategoryId=3}
                            }
                        );
        }
    }
}