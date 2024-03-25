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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new List<Product>() {
                    new() {Id=1,Name="Samsung s16", Price=25000,Description="Akıllı Telefon",Category="Telefon"},
                    new() {Id=2,Name="Samsung s17", Price=26000,Description="Baya Akıllı Telefon",Category="Telefon"},
                    new() {Id=3,Name="Samsung s18", Price=27000,Description="Çok Akıllı Telefon",Category="Telefon"},
                    new() {Id=4,Name="Samsung s19", Price=28000,Description="En Akıllı Telefon",Category="Telefon"},
                    new() {Id=5,Name="Samsung s20", Price=29000,Description="En En Akıllı Telefon",Category="Telefon"},
                    new() {Id=6,Name="Samsung s21", Price=30000,Description="Senden Akıllı Telefon",Category="Telefon"},
                    new() {Id=7,Name="Samsung s22", Price=31000,Description="yeni model Akıllı Telefon",Category="Telefon"},
                    new() {Id=8,Name="Samsung s23", Price=32000,Description="Inanılmaz zeki ve Akıllı Telefon",Category="Telefon"}
                }
            );
        }
    }
}